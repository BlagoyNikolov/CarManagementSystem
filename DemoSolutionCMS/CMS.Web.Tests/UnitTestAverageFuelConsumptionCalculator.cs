using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.Common;

namespace CMS.Tests
{
    [TestClass]
    public class UnitTestAverageFuelConsumptionCalculator
    {
        [TestMethod]
        public void TestAverageFuelConsumptionLiters()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionLiters(52, 800);
            Assert.AreEqual(6.5, result, 0.01);
        }

        [TestMethod]
        public void TestAverageFuelConsumptionLitersAlt()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionLiters(26, 235);
            Assert.AreEqual(11.063, result, 0.01);
        }

        [TestMethod]
        public void TestAverageFuelConsumptionLitersInvalidFilled()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionLiters(0, 800);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAverageFuelConsumptionLitersInvalidMileage()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionLiters(52, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAverageFuelConsumptionLitersBothInvalid()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionLiters(0, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAverageFuelConsumptionGallons()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionMPG(17, 350);
            Assert.AreEqual(20.58, result, 0.01);
        }

        [TestMethod]
        public void TestAverageFuelConsumptionGallonsAlt()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionMPG(23, 417);
            Assert.AreEqual(18.13, result, 0.01);
        }

        [TestMethod]
        public void TestAverageFuelConsumptionGallonsInvalidFilled()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionMPG(0, 371);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAverageFuelConsumptionGallonsInvalidMileage()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionMPG(29, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAverageFuelConsumptionGallonsBothInvalid()
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionMPG(0, 0);
            Assert.AreEqual(0, result);
        }
    }
}
