using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW10Tests
    {

        [TestMethod]
        public void ChkIfArrIsPrime_Null_ReturnsFalse()
        {
            // arrange
            bool actual;
            int[] arr = null;

            // act
            actual = HW10.ChkIfArrIsPrime(arr);

            // assert
            Assert.IsFalse( actual, "Should get false but got " + actual);

        }

        [TestMethod]
        public void ChkIfArrIsPrime_EmptyArr_ReturnsFalse()
        {
            // arrange
            bool actual;
            int[] arr = { };

            // act
            actual = HW10.ChkIfArrIsPrime(arr);

            // assert
            Assert.IsFalse(actual, "Should get false but got " + actual);

        }


        [TestMethod]
        public void ChkIfArrIsPrime_ArrWhereNumOfPrimesHigherThanNumOfNotPrimes_ReturnsTrue()
        {
            // arrange
            bool actual;
            int[] arr = { 1, 2, 3, 5, 6, 7 };

            // act
            actual = HW10.ChkIfArrIsPrime(arr);

            // assert
            Assert.IsTrue(actual, "Should get true but got " + actual);

        }

        [TestMethod]
        [DataRow(null, false, DisplayName = "ChkIfArrIsPrime_Null_ReturnsFalse")]
        [DataRow(new int[] {}, false, DisplayName = "ChkIfArrIsPrime_EmptyArr_ReturnsFalse")]
        [DataRow(new int[] { 1,2,3,5,6,7} , true , DisplayName = "ChkIfArrIsPrime_ArrWhereNumOfPrimesHigherThanNumOfNotPrimes_ReturnsTrue")]
        [DataRow(new int[] {-5,1,10,20,2,3 }, false, DisplayName = "ChkIfArrIsPrime_ArrWhereNumOfPrimesLowerThanNumOfNotPrimes_ReturnsFalse")]
        [DataRow(new int[] {2,3,5}, true, DisplayName = "ChkIfArrIsPrime_ArrOfOnlyPrimeNumbers_ReturnsTrue")]
        [DataRow(new int[] { 10,-3,-2}, false, DisplayName = "ChkIfArrIsPrime_ArrOfOnlyNotPrimeNumbers_ReturnsFalse")]
        public void ChkIfArrIsPrime(int[] arr , bool expected)
        {
            // arrange
            bool actual;

            // act
            actual = HW10.ChkIfArrIsPrime(arr);

            // assert
            Assert.AreEqual(expected,actual,"Should get " + expected + " but got " + actual);

        }


     
    }
}