using NUnit.Framework;
using DateTimeExample;


namespace DateTimeExampleTest
{
    public class Tests
    {
        string timeOfDay;
        [SetUp]
        public void Setup()
        {

            timeOfDay = SetTime.GetTimeOfDay();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Night",timeOfDay);
        }
    }
}