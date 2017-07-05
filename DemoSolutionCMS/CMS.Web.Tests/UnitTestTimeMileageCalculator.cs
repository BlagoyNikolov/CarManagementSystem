using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.Common;

namespace CMS.Tests
{
    [TestClass]
    public class UnitTestTimeMileageCalculator
    {
        [TestMethod]
        public void TestGetRemainingMonths()
        {
            int result = TimeMileageCalculator.GetRemainingMonths(12, 9);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestGetRemainingMonthsOverdue()
        {
            int result = TimeMileageCalculator.GetRemainingMonths(12, 14);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestGetRemainingMonthsInvalid()
        {
            int result = TimeMileageCalculator.GetRemainingMonths(6, -2);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGetRemainingMileage()
        {
            int result = TimeMileageCalculator.GetRemainingMileage(10000, 400, 9);
            Assert.AreEqual(6400, result);
        }

        [TestMethod]
        public void TestGetRemainingMileageAlt()
        {
            int result = TimeMileageCalculator.GetRemainingMileage(12500, 540, 14);
            Assert.AreEqual(4940, result);
        }

        [TestMethod]
        public void TestGetRemainingMileageOverdue()
        {
            int result = TimeMileageCalculator.GetRemainingMileage(15000, 650, 24);
            Assert.AreEqual(-600, result);
        }

        [TestMethod]
        public void TestGetRemainingMileageInvalid()
        {
            int result = TimeMileageCalculator.GetRemainingMileage(-5, 480, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGetRemainingMonthsOrMileage()
        {
            string result = TimeMileageCalculator.GetRemainingMonthsOrMileage(12, 10000, 450, 9);
            Assert.AreEqual("Time remaining 3, Mileage remaining 5950", result);
        }

        [TestMethod]
        public void TestGetRemainingMonthsOrMileageAlt()
        {
            string result = TimeMileageCalculator.GetRemainingMonthsOrMileage(24, 25000, 1050, 19);
            Assert.AreEqual("Time remaining 5, Mileage remaining 5050", result);
        }

        [TestMethod]
        public void TestGetRemainingMonthsOrMileageOverdue()
        {
            string result = TimeMileageCalculator.GetRemainingMonthsOrMileage(24, 35000, 890, 26);
            Assert.AreEqual("Time remaining -2, Mileage remaining 11860", result);
        }

        [TestMethod]
        public void TestGetRemainingMonthsOrMileageInvalid()
        {
            string result = TimeMileageCalculator.GetRemainingMonthsOrMileage(0, 10000, -2, 9);
            Assert.AreEqual("Time remaining 0, Mileage remaining 0", result);
        }
    }
}
