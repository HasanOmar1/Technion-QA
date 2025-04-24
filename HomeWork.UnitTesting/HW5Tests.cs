using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW5Tests
    {
        [TestMethod]
        public void IsValidCellNum_ValidCellNum_ReturnsTrue()
        {

            // arrange
            string cellNumToTest = "055-1234567";
            bool actual;
            HW5 myCode = new HW5();

            // act
            actual = myCode.IsValidCellNum(cellNumToTest);
 
            // assert
            Assert.IsTrue(actual , "BUG: 055-1234567 is a valid cell number");
        }
    

        [TestMethod]
        public void IsValidCellNum_WrongPrefix_ReturnsFalse()
        {
            // arrange
            string cellNumToTest = "060-1234567";
            bool actual;
            HW5 myCode = new HW5();

            // act
            actual = myCode.IsValidCellNum(cellNumToTest);

            // assert
            Assert.IsFalse(actual, "BUG: 060-1234567 is not a valid cell number (starts with 060)");
        }
    

        [TestMethod]
        public void IsValidCellNum_NoDash_ReturnsFalse()
        {

            // arrange
            string cellNumToTest = "0501234567";
            bool actual;
            HW5 myCode = new HW5();

            // act
            actual = myCode.IsValidCellNum(cellNumToTest);

            // assert
            Assert.IsFalse(actual, "BUG: 0501234567 is not a valid cell number (no dash)");
        }

        [TestMethod]
        public void IsValidCellNum_DashInWrongPosition_ReturnsFalse()
        {

            // arrange
            string cellNumToTest = "0501-234567";
            bool actual;
            HW5 myCode = new HW5();

            // act
            actual = myCode.IsValidCellNum(cellNumToTest);

            // assert
            Assert.IsFalse(actual, "BUG: 0501-234567 is not a valid cell number (dash should be the 4th char)");
        }

        [TestMethod]
        public void IsValidCellNum_CellNumTooShort_ReturnsFalse()
        {


            // arrange
            string cellNumToTest = "050-123456";
            bool actual;
            HW5 myCode = new HW5();

            // act
            actual = myCode.IsValidCellNum(cellNumToTest);

            // assert
            Assert.IsFalse(actual, "BUG: 050-123456 is not a valid cell number (cell number is too short)");
        }

        [TestMethod]
        public void IsValidCellNum_CellNumTooLong_ReturnsFalse()
        {


            // arrange
            string cellNumToTest = "050-12345678";
            bool actual;
            HW5 myCode = new HW5();

            // act
            actual = myCode.IsValidCellNum(cellNumToTest);

            // assert
            Assert.IsFalse(actual, "BUG: 050-12345678 is not a valid cell number (cell number is too long)");
        }

        [TestMethod]
        public void IsValidCellNum_IllegalChars_ReturnsFalse()
        {

            // arrange
            string cellNumToTest = "050-123@567";
            bool actual;
            HW5 myCode = new HW5();

            // act
            actual = myCode.IsValidCellNum(cellNumToTest);

            // assert
            Assert.IsFalse(actual, "BUG: 050-123@567 is not a valid cell number (illegal chars)");
        }

        [TestMethod]
        public void IsValidCellNum_NULL_ReturnsFalse()
        {

            // arrange
            string cellNumToTest = null;
            bool actual;
            HW5 myCode = new HW5();

            // act
            actual = myCode.IsValidCellNum(cellNumToTest);

            // assert
            Assert.IsFalse(actual, "BUG: null input should be considered as none valid cell number ");
        }

        [TestMethod]
        public void IsValidCellNum_isEmpty_ReturnsFalse()
        {

            // arrange
            string cellNumToTest = "";
            bool actual;
            HW5 myCode = new HW5();

            // act
            actual = myCode.IsValidCellNum(cellNumToTest);

            // assert
            Assert.IsFalse(actual, "BUG: null input should be considered as none valid cell number ");
        }
    }
}


