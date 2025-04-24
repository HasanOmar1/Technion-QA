using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW7Tests
    {
        [TestMethod]
        public void Brothers_Num1Is13Num2Is123_ReturnsTrue()
        {
            // Arrange
            bool actual;
            int num1 = 13, num2 = 123;

            // Act
            actual = HW7.Brothers(num1, num2);

            // Assert
            Assert.IsTrue(actual , "Should return true but got " + actual);
        }

        [TestMethod]
        public void Brothers_Num1Is7Num2Is71237_ReturnsTrue()
        {
            // Arrange
            bool actual;
            int num1 = 7, num2 = 71237;

            // Act
            actual = HW7.Brothers(num1, num2);

            // Assert
            Assert.IsTrue(actual, "Should return true but got " + actual);
        }

        [TestMethod]
        public void Brothers_Num1Is14Num2Is15_ReturnsFalse()
        {
            // Arrange
            bool actual;
            int num1 = 14, num2 = 15;

            // Act
            actual = HW7.Brothers(num1, num2);

            // Assert
            Assert.IsFalse(actual, "Should return false but got " + actual);
        }

        [TestMethod]
        public void Brothers_Num1IsMinus13Num2Is10_ReturnsFalse()
        {
            // Arrange
            bool actual;
            int num1 = -13, num2 = 10;

            // Act
            actual = HW7.Brothers(num1, num2);

            // Assert
            Assert.IsFalse(actual, "Should return false but got " + actual);
        }


        [TestMethod]
        public void Brothers_Num1Is13Num2IsMinus10_ReturnsFalse()
        {
            // Arrange
            bool actual;
            int num1 = 13, num2 = -10;

            // Act
            actual = HW7.Brothers(num1, num2);

            // Assert
            Assert.IsFalse(actual, "Should return false but got " + actual);
        }
    }
}
