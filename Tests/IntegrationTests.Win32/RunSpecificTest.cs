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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationTests.Shared;
using NUnit.Framework;

namespace IntegrationTests.Win32
{
    [TestFixture]
    public class RunSpecificTest
    {
        [Test, Explicit("Use this to run a specific test once")]
        public void RunTest()
        {
            var testFixture = new SimpleLINQtests();
            testFixture.Setup();

            testFixture.CreateList();

            testFixture.TearDown();
        }
    }
}
