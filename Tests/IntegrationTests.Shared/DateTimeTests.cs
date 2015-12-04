﻿using NUnit.Framework;
using Realms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Linq;

namespace IntegrationTests.Shared
{
    [TestFixture]
    public class DateTimeTests
    {
        //TODO: this is ripe for refactoring across test fixture classes

        protected string _databasePath;
        protected Realm _realm;

        [SetUp]
        public void Setup()
        {
            _databasePath = Path.GetTempFileName();
            _realm = Realm.GetInstance(_databasePath);
        }

        [TearDown]
        public void TearDown()
        {
            _realm.Dispose();
        }

        [Test]
        public void SetAndGetPropertyTest()
        {
            var turingsBirthday = new DateTimeOffset(1912, 6, 23, 0, 0, 0, TimeSpan.Zero);

            Person turing;
            using (var transaction = _realm.BeginWrite())
            {
                turing = _realm.CreateObject<Person>();
                turing.FirstName = "Alan";
                turing.LastName = "Turing";
                turing.Birthday = turingsBirthday;
                transaction.Commit();
            }

            // perform a db fetch
            var turingAgain = _realm.All<Person>().ToList()[0];

            Assert.That(turingAgain.Birthday, Is.EqualTo(turingsBirthday));
        }
    }
}