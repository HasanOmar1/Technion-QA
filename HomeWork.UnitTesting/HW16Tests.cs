using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW16Tests
    {
        [DataTestMethod]
        [DataRow(new int[] {1,2,3} , 2 , new int[] {1,1,2,2,3,3} , DisplayName = "buildK_validArrWithK2_ReturnsArrWithEveryMemberDuplicated2Times")]
        [DataRow(new int[] { 1, 2, 3 }, 0, new int[] { 1, 2,3 } , DisplayName = "buildK_validArrWithK0_ReturnsArrWithSameMembersAsOriginal")]

        public void buildK(int[] a , int k , int[] expected)
        {
            // Arrange
            int[] actual;

            // Act
            actual = HW16.buildK(a,k);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length , "Error in array length");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i] , "Error at index #" + i);

        }
    }
}
