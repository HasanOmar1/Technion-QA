using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW4Tests
    {
        //[TestMethod]
        //public void perfectNumber_numIs24_ReturnsTrue()
        //{
        //    // arrange
        //    bool actual;

        //    // act
        //    actual = HW4.perfectNumber(24);

        //    // assert
        //    Assert.IsTrue(actual , "Should return true but got " + actual);
        //}

        //[TestMethod]
        //public void perfectNumber_numIs12_ReturnsTrue()
        //{
        //    // arrange
        //    bool actual;

        //    // act
        //    actual = HW4.perfectNumber(12);

        //    // assert
        //    Assert.IsTrue(actual, "Should return true but got " + actual);
        //}


        //[TestMethod]
        //public void perfectNumber_numIs25_ReturnsFalse()
        //{
        //    // arrange
        //    bool actual;

        //    // act
        //    actual = HW4.perfectNumber(25);

        //    // assert
        //    Assert.IsFalse(actual, "Should return false but got " + actual);
        //}


        //[TestMethod]
        //public void perfectNumber_numIsMinus24_ReturnsFalse()
        //{
        //    // arrange
        //    bool actual;

        //    // act
        //    actual = HW4.perfectNumber(-24);

        //    // assert
        //    Assert.IsFalse(actual, "Should return false but got " + actual);
        //}

        //[TestMethod]
        //public void perfectNumber_numIs0_ReturnsFalse()
        //{
        //    // arrange
        //    bool actual;

        //    // act
        //    actual = HW4.perfectNumber(0);

        //    // assert
        //    Assert.IsFalse(actual, "Should return false but got " + actual);
        //}

        [TestMethod]
        [DataRow(24,true,DisplayName = "perfectNumber_numIs24_ReturnsTrue")]
        [DataRow(12, true, DisplayName = "perfectNumber_numIs12_ReturnsTrue")]
        [DataRow(25, false, DisplayName = "perfectNumber_numIs25_ReturnsFalse")]
        [DataRow(-24, false, DisplayName = "perfectNumber_numIs-24_ReturnsFalse")]
        [DataRow(0, false, DisplayName = "perfectNumber_numIs0_ReturnsFalse")]

        public void perfectNumber(int num , bool expected)
        {
            // arrange
            bool actual;

            // act
            actual = HW4.perfectNumber(num);

            // assert
            Assert.AreEqual(expected,actual, "Should return " + expected +" but got " + actual);
        }
    }
}
