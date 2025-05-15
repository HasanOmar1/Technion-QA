using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW13Tests
    {
        [TestMethod]
        public void SolveQuadraticEquation_EqWith2Sol_ReturnsInRelevantOrder()
        {
            // -x^2 + 12x - 32 = 0 ---> x1 = 8 , x2 = 4 

            // Arrange
            HW13 myCode = new HW13();
            int[] coEfficients = { -1, 12, -32 };
            string[] actual;
            string[] expected = { "2", "8", "4" };
            
            // Act
            actual = myCode.SolveQuadraticEquation(coEfficients);

            // Assert
            if (actual == null)
                Assert.Fail("Should not return null");

            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Bug in index #" + i);


        }


        [TestMethod]
        public void SolveQuadraticEquation_EqWith0Sol_Returns0NullNull()
        {
            // -3x^2 + 2x - 4 = 0 ---> no solutions 

            // Arrange
            HW13 myCode = new HW13();
            int[] coEfficients = {-3,2,-4 };
            string[] actual;
            string[] expected = {"0" , null , null};

            // Act
            actual = myCode.SolveQuadraticEquation(coEfficients);

            // Assert
            if (actual == null)
                Assert.Fail("Should not return null");

            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Bug in index #" + i);


        }
    }
}
