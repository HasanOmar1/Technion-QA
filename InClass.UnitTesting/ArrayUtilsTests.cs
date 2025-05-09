using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InClass.UnitTesting
{
    [TestClass]
    public class ArrayUtilsTests
    {
        [TestMethod]
        public void GetEvenItemsInIntArray_ArrayWithEvenNumsAndOddNumbers_ReturnsOnlyEven()
        {

            // Arrange
            int[] arrToTest = { -3, 1, 10, 3, 8, 20 };
            int[] expected = { 10, 8, 20 };
            int[] actual;

            ArrayUtils myCode = new ArrayUtils();

            // Act
            actual = myCode.GetEvenItemsInIntArray(arrToTest);

            // Assert

            // if we get null the test should fail
            if (actual == null)
                Assert.Fail("We shouldnt get null as a result");


            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Problem in item #" + i);
        }

        [TestMethod]
        public void GetEvenItemsInIntArray_ArrayWithOnlyEvenNums_ReturnsInputArray()
        {

            // Arrange
            int[] arrToTest = { 6, 8, 10 };
            int[] expected = { 6, 8, 10 };
            int[] actual;

            ArrayUtils myCode = new ArrayUtils();

            // Act
            actual = myCode.GetEvenItemsInIntArray(arrToTest);

            // Assert

            // if we get null the test should fail
            if (actual == null)
                Assert.Fail("We shouldnt get null as a result");


            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Problem in item #" + i);
        }


        [TestMethod]
        public void GetEvenItemsInIntArray_ArrayWithOutEvenNums_ReturnsEmptyArr()
        {

            // Arrange
            int[] arrToTest = { -3, 1, 101, 3, 81, 201 };
            int[] expected = { };
            int[] actual;

            ArrayUtils myCode = new ArrayUtils();

            // Act
            actual = myCode.GetEvenItemsInIntArray(arrToTest);

            // Assert

            // if we get null the test should fail
            if (actual == null)
                Assert.Fail("We shouldnt get null as a result");

            // if the code comes here then both actual and expected are not null
            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");
            //Assert.AreEqual(0, actual.Length, "Bug in array length");


        }

        [TestMethod]
        public void GetEvenItemsInIntArray_Null_ReturnsNull()
        {

            // Arrange
            int[] arrToTest = null;
            int[] expected = null;
            int[] actual;

            ArrayUtils myCode = new ArrayUtils();

            // Act
            actual = myCode.GetEvenItemsInIntArray(arrToTest);

            // Assert
            // option 1:
            Assert.IsNull(actual, "BUG: We should have got null");

            // option 2:
            //if (actual == null) // we expect to get null , and indeed we got null
            //{
            //    Assert.IsTrue(true);
            //    return;

            //}
            //else
            //    Assert.Fail("BUG: We should have got null");




        }


        [TestMethod]
        public void GetEvenItemsInIntArray_EmptyArray_ReturnsEmptyArr()
        {

            // Arrange
            int[] arrToTest = { };
            int[] expected = { };
            int[] actual;

            ArrayUtils myCode = new ArrayUtils();

            // Act
            actual = myCode.GetEvenItemsInIntArray(arrToTest);

            // Assert

            // if we get null the test should fail
            if (actual == null)
                Assert.Fail("We shouldnt get null as a result");

            // if the code comes here then both actual and expected are not null
            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");
            //Assert.AreEqual(0, actual.Length, "Bug in array length");

        }

        [TestMethod]
        [DataRow(new int[] { -3, 1, 10, 3, 8, 20 }, new int[] { 10, 8, 20 }, DisplayName = "GetEvenItemsInIntArray_ArrayWithEvenNumsAndOddNumbers_ReturnsOnlyEven")]
        [DataRow(new int[] { 20 }, new int[] { 20 }, DisplayName = "GetEvenItemsInIntArray_ArrayWithSingleEvenNumber_ReturnsArrWithOnlySingleNumber")]

        [DataRow(new int[] { 6, 8, 10 }, new int[] { 6, 8, 10 },
            DisplayName = "GetEvenItemsInIntArray_ArrayWithOnlyEvenNums_ReturnsInputArray")]

        [DataRow(new int[] { -3, 1, 101, 3, 81, 201 }, new int[] { },
            DisplayName = "GetEvenItemsInIntArray_ArrayWithOutEvenNums_ReturnsEmptyArr")]

        [DataRow(null, null, DisplayName = "GetEvenItemsInIntArray_Null_ReturnsNull")]

        [DataRow(new int[] { }, new int[] { }, DisplayName = "GetEvenItemsInIntArray_EmptyArray_ReturnsEmptyArr")]


        public void GetEvenItemsInIntArray(int[] arr, int[] expected)
        {

            // Arrange
            int[] actual;

            ArrayUtils myCode = new ArrayUtils();

            // Act
            actual = myCode.GetEvenItemsInIntArray(arr);

            // Assert

            // if we get null the test should fail
            if (expected == null && actual == null)
            {
                Assert.IsTrue(true);
                return;

            }

            if (expected == null && actual != null)
                Assert.Fail("We expected null but didnt get null");

            if (expected != null && actual == null)
                Assert.Fail("We didnt expect null but we got null");


            // if the code comes here then both actual and expected are not null
            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Problem in item #" + i);

        }
    }
}
