using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW8Tests
    {
        [TestMethod]
        public void GetMaxNumInIntArr_ArrWithMax120InMidIndex_Returns120()
        {
            // arrange
            int[] arr = { -324, 0, 12, 120, 120, 45, -3511, int.MinValue };

            int actual;
            int expected = 120;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual,"BUG: the max should be " + expected);
            //Assert.IsTrue(expected == actual, "BUG: the max should be " + expected);

        }


        [TestMethod]
        public void GetMaxNumInIntArr_ArrWithMax120InLastIndex_Returns120()
        {
            // arrange
            int[] arr = { -324, 0, 12, 45, -3511, int.MinValue,120 };

            int actual;
            int expected = 120;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
             Assert.AreEqual(expected, actual,"BUG: the max should be " + expected);
            //Assert.IsTrue(expected == actual, "BUG: the max should be " + expected);
        }

        [TestMethod]
        public void GetMaxNumInIntArr_ArrWithMax120InFirstIndex_Returns120()
        {
            // arrange
            int[] arr = {120, -324, 0, 12, 45, -3511, int.MinValue };

            int actual;
            int expected = 120;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual, "BUG: the max should be " + expected);
            //Assert.IsTrue(expected == actual, "BUG: the max should be " + expected);
        }

        [TestMethod]
        public void GetMaxNumInIntArr_ArrWithSingleMember120_Returns120()
        {
            // arrange
            int[] arr = { 120 };

            int actual;
            int expected = 120;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual, "BUG: the max should be " + expected);
            //Assert.IsTrue(expected == actual, "BUG: the max should be " + expected);
        }

        [TestMethod]
        public void GetMaxNumInIntArr_EmptyArr_ReturnsIntMinValue()
        {
            // arrange
            int[] arr = { };

            int actual;
            int expected = int.MinValue;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual, "BUG: the max should be " + expected);
        }

        [TestMethod]
        public void GetMaxNumInIntArr_NULL_ReturnsIntMinValue()
        {
            // arrange
            int[] arr = null;

            int actual;
            int expected = int.MinValue;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual, "BUG: the max should be " + expected);
        }

        [TestMethod]
        public void GetMaxNumInIntArr_ArrWithMaxIntMinValue_ReturnsIntMinValue()
        {
            // arrange
            int[] arr = {int.MinValue };
            int actual;
            int expected = int.MinValue;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual, "BUG: the max should be " + expected);
        }
        [TestMethod]
        public void GetMaxNumInIntArr_ArrWithMaxIntIntMaxValue_ReturnsIntMaxValue()
        {
            // arrange
            int[] arr = {1,2,3,4,5,6,7, int.MaxValue };
            int actual;
            int expected = int.MaxValue;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual, "BUG: the max should be " + expected);
        }
        [TestMethod]
        public void GetMaxNumInIntArr_ArrWithMaxMinus17_ReturnsMinus17()
        {
            // arrange
            int[] arr = { -100,-200,-300,-17,-20, int.MinValue };

            int actual;
            int expected = -17;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual, "BUG: the max should be " + expected);
            //Assert.IsTrue(expected == actual, "BUG: the max should be " + expected);

        }

        [TestMethod]
        public void GetMaxNumInIntArr_ArrWithSameValues5_Returns5()
        {
            // arrange
            int[] arr = { 5,5,5,5,5,5 };

            int actual;
            int expected = 5;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual, "BUG: the max should be " + expected);
            //Assert.IsTrue(expected == actual, "BUG: the max should be " + expected);
        }

        [TestMethod]
        [DataRow(new int [] { -324, 0, 12, 120, 120, 45, -3511, int.MinValue },120,DisplayName = "GetMaxNumInIntArr_ArrWithMax120InMidIndex_Returns120")]
        [DataRow(new int[] { -324, 0, 12, 45, -3511, int.MinValue, 120 }, 120, DisplayName = "GetMaxNumInIntArr_ArrWithMax120InLastIndex_Returns120")]
        [DataRow(new int[] { 120, -324, 0, 12, 45, -3511, int.MinValue }, 120, DisplayName ="GetMaxNumInIntArr_ArrWithMax120InFirstIndex_Returns120")]
        [DataRow(new int[] { 120 }, 120, DisplayName = "GetMaxNumInIntArr_ArrWithSingleMember120_Returns120")]
        [DataRow(new int[] {  }, int.MinValue, DisplayName = "GetMaxNumInIntArr_EmptyArr_ReturnsIntMinValue")]
        [DataRow(null, int.MinValue, DisplayName = "GetMaxNumInIntArr_NULL_ReturnsIntMinValue")]
        [DataRow(new int[] { int.MinValue }, int.MinValue, DisplayName = "GetMaxNumInIntArr_ArrWithMaxIntMinValue_ReturnsIntMinValue")]
        [DataRow(new int[] {1,2, int.MaxValue,3,4,5 }, int.MaxValue, DisplayName = "GetMaxNumInIntArr_ArrWithMaxIntIntMaxValue_ReturnsIntMaxValue")]
        [DataRow(new int[] { -100, -200, -300, -17, -20, int.MinValue }, -17, DisplayName = "GetMaxNumInIntArr_ArrWithMaxMinus17_Returns-17")]
        [DataRow(new int[] { 5,5,5,5,5 }, 5, DisplayName = "GetMaxNumInIntArr_ArrWithSameValues5_Returns5")]
        public void GetMaxNumInIntArr(int[] arr , int expected)
        {
            // arrange
            int actual;

            // act
            actual = HW8.GetMaxNumInIntArr(arr);

            // assert
            Assert.AreEqual(expected, actual, "BUG: the max should be " + expected);
            //Assert.IsTrue(expected == actual, "BUG: the max should be " + expected);
        }
    }
}