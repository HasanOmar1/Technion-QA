using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InClass.UnitTesting
{
    [TestClass]
    public class ArrayUtilsTests
    {
        [TestMethod]
        public void GetEvenItemsInIntArray_ArrayWithEvenNums_ReturnsEvenArr()
        {

            // Arrange
            int[] arrToTest = { -3, 1, 10, 3, 8, 20 };
            int[] expected = { 10,8,20 };
            int[] actual;

            ArrayUtils myCode = new ArrayUtils();

            // Act
            actual = myCode.GetEvenItemsInIntArray(arrToTest);

            // Assert

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

            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Problem in item #" + i);
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

            if(expected == null && actual == null)
            {
                Assert.IsTrue(true);
                return;
            }


            if (expected == null && actual != null)
                Assert.Fail("I was expecting null but didnt get null");

            if (expected != null && actual == null)
                Assert.Fail("I was NOT expecting null but i got null");


            // if the code comes here then we know that expected and actual are not null

            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Problem in item #" + i);
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

            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Problem in item #" + i);
        }
    }
}
