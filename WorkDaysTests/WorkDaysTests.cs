using NUnit.Framework;
using System;

namespace WorkDays.Tests
{
    [TestFixture()]
    public class WorkDaysCounterTests
    {
        [Test]
        public void Start2March10workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(12, workDays.DaysCounter(new DateTime(2020, 03, 2), 10));
        }

        [Test]
        public void Start2March11workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(15, workDays.DaysCounter(new DateTime(2020, 03, 2), 11));
        }

        [Test]
        public void Start2March15workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(19, workDays.DaysCounter(new DateTime(2020, 03, 2), 15));
        }

        [Test]
        public void Start3March1workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(2, workDays.DaysCounter(new DateTime(2020, 03, 3), 1));
        }

        [Test]
        public void Start3March15workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(21, workDays.DaysCounter(new DateTime(2020, 03, 3), 15));
        }

        [Test]
        public void Start3March10workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(14, workDays.DaysCounter(new DateTime(2020, 03, 3), 10));
        }
    }
}