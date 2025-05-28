using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW16Tests
    {
        [TestMethod]
        public void buildK_validArr_ReturnsValidData(int[] a , int k , int[] expected)
        {
            // Arrange
            int[] actual;

            // Act
            actual = HW16.buildK(a,k);

            // Assert
            Assert.AreEqual(expected.Length / k, actual.Length);
           
        }
    }
}
