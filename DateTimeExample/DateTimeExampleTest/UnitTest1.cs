using NUnit.Framework;
using DateTimeExample;
using System;

namespace DateTimeExampleTest
{
    public class Tests
    {
        string timeOfDay;
        [SetUp]
        public void Setup()
        {

            timeOfDay = SetTime.GetTimeOfDay(new DateTime(2015, 12, 31, 06, 00, 00));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Morning",timeOfDay);
        }

        [Test]
        public void Test2()
        {
            Assert.AreNotEqual("Night", timeOfDay);
        }
    }
}