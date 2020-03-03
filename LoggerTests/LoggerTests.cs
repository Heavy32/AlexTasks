using NUnit.Framework;
using System.Reflection;
using System.Linq;

namespace Logger.Tests
{
    public class LoggerTests
    {
        [Test]
        public void GreenCucumberPropertiesNames()
        {
            Cucumber greenCucumber = new Cucumber("green", 10, 0.5f, true);
            Logger.Logger<Cucumber> logger = new Logger<Cucumber>();

            PropertyInfo[] actualProperties = logger.GetProperties(greenCucumber);
            string[] expectedPropertiesNames = { "color", "length", "weight", "isTasty" };

            var actualPropertiesNames = Enumerable.Range(0, actualProperties.Length).Select(x => actualProperties[x].Name).ToArray();
            Assert.AreEqual(expectedPropertiesNames, actualPropertiesNames);
        }

        [Test]
        public void GreenCucumberPropertiesValues()
        {
            Cucumber greenCucumber = new Cucumber("green", 10, 0.5f, true);
            Logger.Logger<Cucumber> logger = new Logger<Cucumber>();

            PropertyInfo[] actualProperties = logger.GetProperties(greenCucumber);
            string[] expectedPropertiesValues = { "green", "10", "0,5", "True" };

            var actualPropertiesNames = Enumerable.Range(0, actualProperties.Length)
                                                  .Select(x => actualProperties[x].GetValue(greenCucumber).ToString())
                                                  .ToArray();
            Assert.AreEqual(expectedPropertiesValues, actualPropertiesNames);
        }

        [Test]
        public void BossPropertiesNames()
        {
            Person boss = new Person(30, "James");
            Logger.Logger<Person> logger = new Logger<Person>();

            PropertyInfo[] actualProperties = logger.GetProperties(boss);
            string[] expectedPropertiesNames = { "name", "age" };

            var actualPropertiesNames = Enumerable.Range(0, actualProperties.Length)
                                                  .Select(x => actualProperties[x].Name)
                                                  .ToArray();
            Assert.AreEqual(expectedPropertiesNames, actualPropertiesNames);
        }

        [Test]
        public void BossPropertiesValues()
        {
            Person boss = new Person(30, "James");
            Logger.Logger<Person> logger = new Logger<Person>();

            PropertyInfo[] actualProperties = logger.GetProperties(boss);
            string[] expectedPropertiesValues = { "James", "30" };

            var actualPropertiesNames = Enumerable.Range(0, actualProperties.Length)
                                                  .Select(x => actualProperties[x].GetValue(boss).ToString())
                                                  .ToArray();
            Assert.AreEqual(expectedPropertiesValues, actualPropertiesNames);
        }
    }
}