﻿using NUnit.Framework;
using System;

namespace WorkDays.Tests
{
    [TestFixture]
    public class WorkDaysCounterTests
    {
        [Test]
        public void Start20April1workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(1, workDays.DaysCounter(new DateTime(2020, 04, 20), 1));
        }

        [Test]
        public void Start20April2workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(2, workDays.DaysCounter(new DateTime(2020, 04, 20), 2));
        }

        [Test]
        public void Start20April3workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(3, workDays.DaysCounter(new DateTime(2020, 04, 20), 3));
        }

        [Test]
        public void Start20April4workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(4, workDays.DaysCounter(new DateTime(2020, 04, 20), 4));
        }

        [Test]
        public void Start20April5workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(5, workDays.DaysCounter(new DateTime(2020, 04, 20), 5));
        }

        [Test]
        public void Start20April6workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(8, workDays.DaysCounter(new DateTime(2020, 04, 20), 6));
        }

        [Test]
        public void Start21April5workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(7, workDays.DaysCounter(new DateTime(2020, 04, 21), 5));
        }

        [Test]
        public void Start20April7workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(9, workDays.DaysCounter(new DateTime(2020, 04, 20), 7));
        }

        [Test]
        public void Start20April11workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(15, workDays.DaysCounter(new DateTime(2020, 04, 20), 11));
        }

        [Test]
        public void Start23April2workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(2, workDays.DaysCounter(new DateTime(2020, 04, 23), 2));
        }

        [Test]
        public void Start21April4workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(4, workDays.DaysCounter(new DateTime(2020, 04, 21), 4));
        }

        [Test]
        public void Start20April10workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(12, workDays.DaysCounter(new DateTime(2020, 04, 20), 10));
        }

        [Test]
        public void Start27April1workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(9, workDays.DaysCounter(new DateTime(2020, 04, 27), 7));
        }

        [Test]
        public void Start22April13workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(17, workDays.DaysCounter(new DateTime(2020, 04, 22), 13));
        }

        [Test]
        public void Start22April14workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(20, workDays.DaysCounter(new DateTime(2020, 04, 22), 14));
        }

        [Test]
        public void Start2April21workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(29, workDays.DaysCounter(new DateTime(2020, 04, 2), 21));
        }

        [Test]
        public void Start8April0workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(0, workDays.DaysCounter(new DateTime(2020, 04, 8), 0));
        }

        [Test]
        public void Start10April1workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(1, workDays.DaysCounter(new DateTime(2020, 04, 10), 1));
        }

        [Test]
        public void Start8April6workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(8, workDays.DaysCounter(new DateTime(2020, 04, 8), 6));
        }

        [Test]
        public void Start10April2workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(4, workDays.DaysCounter(new DateTime(2020, 04, 10), 2));
        }

        [Test]
        public void Start13April15workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(19, workDays.DaysCounter(new DateTime(2020, 04, 13), 15));
        }

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
            Assert.AreEqual(1, workDays.DaysCounter(new DateTime(2020, 03, 3), 1));
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

        [Test]
        public void Start6March1workDays()
        {
            WorkDays workDays = new WorkDays();
            Assert.AreEqual(1, workDays.DaysCounter(new DateTime(2020, 03, 6), 1));
        }
    }
}