﻿////////////////////////////////////////////////////////////////////////////
//
// Copyright 2016 Realm Inc.
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
 
using System;

namespace Realms
{
    internal class ResultsHandle: RealmHandle
    {
        //keep this one even though warned that it is not used. It is in fact used by marshalling
        //used by P/Invoke to automatically construct a ResultsHandle when returning a size_t as a ResultsHandle
        [Preserve]
        public ResultsHandle()
        {
        }

        protected override void Unbind()
        {
            NativeResults.destroy(handle);
        }

        public override bool Equals(object p)
        {
            // If parameter is null, return false. 
            if (ReferenceEquals(p, null))
            {
                return false;
            }

            // Optimization for a common success case. 
            if (ReferenceEquals(this, p))
            {
                return true;
            }

            return NativeResults.is_same_internal_results(this, (ResultsHandle) p) != IntPtr.Zero;
        }
    }
}