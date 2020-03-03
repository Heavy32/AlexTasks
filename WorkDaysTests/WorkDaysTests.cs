using NUnit.Framework;
using System;

namespace WorkDays.Tests
{
    [TestFixture()]
    public class WorkDaysCounterTests
    {
        [Test()]
        public void Test1()
        {
            DateTime start = new DateTime(2020, 2, 3);

            WorkDays workDays = new WorkDays();
            int expected = 5;
            int actual = workDays.WorkDaysCounter(start, 5, 0);

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Test2()
        {
            DateTime start = new DateTime(2020, 2, 3);

            WorkDays workDays = new WorkDays();
            int expected = 12;
            int actual = workDays.WorkDaysCounter(start, 10, 0);

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Test3()
        {
            DateTime start = new DateTime(2020, 2, 7);

            WorkDays workDays = new WorkDays();
            int expected = 4;
            int actual = workDays.WorkDaysCounter(start, 2, 0);

            Assert.AreEqual(expected, actual);
        }

    }
}