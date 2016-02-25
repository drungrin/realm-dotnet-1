////////////////////////////////////////////////////////////////////////////
//
// Copyright 2015 Realm Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
////////////////////////////////////////////////////////////////////////////

#include "impl/cached_realm_base.hpp"

namespace realm {
class Realm;

namespace _impl {

class CachedRealm : public CachedRealmBase {
public:
    using CachedRealmBase::CachedRealmBase;

    // Do nothing, as these can't be implemented portably
    void enable_auto_refresh() { }
    void notify() { }
};

} // namespace _impl
} // namespace realm
