using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW4Tests
    {
        [TestMethod]
        public void perfectNumber_numIs24_ReturnsTrue()
        {
            // arrange
            bool actual;

            // act
            actual = HW4.perfectNumber(24);

            // assert
            Assert.IsTrue(actual , "Should return true but got " + actual);
        }

        [TestMethod]
        public void perfectNumber_numIs12_ReturnsTrue()
        {
            // arrange
            bool actual;

            // act
            actual = HW4.perfectNumber(12);

            // assert
            Assert.IsTrue(actual, "Should return true but got " + actual);
        }


        [TestMethod]
        public void perfectNumber_numIs25_ReturnsFalse()
        {
            // arrange
            bool actual;

            // act
            actual = HW4.perfectNumber(25);

            // assert
            Assert.IsFalse(actual, "Should return false but got " + actual);
        }


        [TestMethod]
        public void perfectNumber_numIsMinus24_ReturnsFalse()
        {
            // arrange
            bool actual;

            // act
            actual = HW4.perfectNumber(-24);

            // assert
            Assert.IsFalse(actual, "Should return false but got " + actual);
        }

        [TestMethod]
        public void perfectNumber_numIs0_ReturnsFalse()
        {
            // arrange
            bool actual;

            // act
            actual = HW4.perfectNumber(0);

            // assert
            Assert.IsFalse(actual, "Should return false but got " + actual);
        }
    }
}
