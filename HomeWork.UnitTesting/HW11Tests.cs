using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW11Tests
    {
        [TestMethod]
        [DataRow("c" , true , DisplayName = "IsSpecial_SingleCharacter_ReturnsTrue")]
        [DataRow("abc", true, DisplayName = "IsSpecial_StringContainsOnlySmallLettersOnce_ReturnsTrue")]
        [DataRow("abca", false, DisplayName = "IsSpecial_StringContainsOnlySmallLettersMoreThanOnce_ReturnsFalse")]

        [DataRow("aB", false, DisplayName = "IsSpecial_StringContainsCapitalLetters_ReturnsFalse")]
        [DataRow("abcde&a", false, DisplayName = "IsSpecial_StringWithNotChar_ReturnsFalse")]
        [DataRow("", false, DisplayName = "IsSpecial_EmptyString_ReturnsFalse")]
        [DataRow(null, false, DisplayName = "IsSpecial_Null_ReturnsFalse")]




        public void IsSpecial(string str , bool expected)
        {

            // Arrange
            bool actual;

            // Act
            actual = HW11.IsSpecial(str);

            // Assert
            Assert.AreEqual(expected, actual , "Bug: Expected " + expected + " but got " + actual);
        }
    }
}
