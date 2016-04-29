/* Copyright 2015 Realm Inc - All Rights Reserved
 * Proprietary and Confidential
 */
 
#ifndef ERROR_HANDLING_HPP
#define ERROR_HANDLING_HPP

#include <string>
#include <realm.hpp>
#include "realm_error_type.hpp"

namespace realm {
struct NativeException {
    RealmErrorType type;
    std::string message;
    
    struct Marshallable {
        RealmErrorType type;
        const char* messagesBytes;
        size_t messageLength;
    };
    
    // the return value of this method is tied to the lifetime of this
    // it's ususally fine to pass it as a parameter to a .net callback,
    // but take care of object lifetime when *returning* this value to .net
    Marshallable for_marshalling() const {
        return {
            type,
            message.data(),
            message.size()
        };
    }
};
    
NativeException convert_exception();

void throw_managed_exception(const NativeException& exception);
    
template <class T>
struct Default {
    static T default_value() {
        return T{};
    }
};
template <>
struct Default<void> {
    static void default_value() {}
};

template <class F>
auto handle_errors(F&& func) -> decltype(func())
{
    using RetVal = decltype(func());
    try {
        return func();
    }
    catch (...) {
        throw_managed_exception(convert_exception());
        return Default<RetVal>::default_value();
    }
}

} // namespace realm

#endif // ERROR_HANDLING_HPP