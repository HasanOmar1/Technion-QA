using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW6Tests
    {
        [TestMethod]
        public void CalcAverageOfIntArr_Null_ReturnsDoubleMinValue()
        {

            // Arrange
            double actual;
            double expected = double.MinValue;

            // Act
            actual = HW6.CalcAverageOfIntArr(null);

            // Assert

            Assert.AreEqual(expected, actual , "Expected double.MinValue but got " + actual);



        }

        [TestMethod]
        public void CalcAverageOfIntArr_EmptyArr_ReturnsDoubleMinValue()
        {

            // Arrange
            double actual;
            double expected = double.MinValue;
            int[] arr = { };

            // Act
            actual = HW6.CalcAverageOfIntArr(arr);

            // Assert

            Assert.AreEqual(expected, actual, "Expected double.MinValue but got " + actual);



        }

        [TestMethod]
        public void CalcAverageOfIntArr_ArrWithDifferentValues_Returns25DotZero()
        {

            // Arrange
            double actual;
            double expected = 25.0;
            int[] arr = {10,20,30,40};

            // Act
            actual = HW6.CalcAverageOfIntArr(arr);

            // Assert

            Assert.AreEqual(expected, actual, "Expected " + expected + " but got " + actual);



        }

        [TestMethod]
        public void CalcAverageOfIntArr_ArrWithSameValuesOf9_Returns9DotZero()
        {

            // Arrange
            double actual;
            double expected = 9.0;
            int[] arr = { 9,9,9,9,9,9,9,9};

            // Act
            actual = HW6.CalcAverageOfIntArr(arr);

            // Assert

            Assert.AreEqual(expected, actual, "Expected " + expected + " but got " + actual);



        }

        [TestMethod]
        public void CalcAverageOfIntArr_ArrWithOneMember6_Returns6DotZero()
        {

            // Arrange
            double actual;
            double expected = 6.0;
            int[] arr = { 6 };

            // Act
            actual = HW6.CalcAverageOfIntArr(arr);

            // Assert

            Assert.AreEqual(expected, actual, "Expected " + expected + " but got " + actual);



        }
    }
}
