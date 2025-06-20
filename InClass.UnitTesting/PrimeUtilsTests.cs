﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InClass.UnitTesting
{
    [TestClass]
    public class PrimeUtilsTests
    {

        private TestContext testContext;

        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }


        [TestMethod]
        [DataRow(17, true, DisplayName = "IsPrime_PrimeNumber_ReturnsTrue")]
        [DataRow(170, false, DisplayName = "IsPrime_NotPrimeNumber_ReturnsFalse")]
        [DataRow(-170, false, DisplayName = "IsPrime_NegativeNumber_ReturnsFalse")]
        public void IsPrime_DataRowTests(int numToTest, bool expected)
        {
            // Arrange
            bool actual;

            // Act
            actual = PrimeUtils.IsPrime(numToTest);

            // Assert
            Assert.AreEqual(expected, actual, "Should return " + expected + " but got " + actual);
        }

        [TestMethod]
        [DynamicData("IsPrimeTestGenerator", DynamicDataSourceType.Method)]
        public void IsPrime_DynamicTests(int numToTest, bool expected)
        {
            // Arrange
            bool actual;

            // Act
            actual = PrimeUtils.IsPrime(numToTest);

            // Assert
            Assert.AreEqual(expected, actual, "Should return " + expected + " but got " + actual);
        }

        public static object[][] IsPrimeTestGenerator()
        {
            return new[]{
                new object[]{ 17,true}  ,//test1
                new object[]{ 170,false},//test2
                new object[]{-170,false},//test3
                new object[]{  2,  true},//test3

            };
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"|DataDirectory|\MyXMLs\PrimeUtilsTests.xml",
            "IsPrimeTest", DataAccessMethod.Sequential)]

        public void IsPrime_XMLTests()
        {
            // Arrange
            bool actual,
                expected = Convert.ToBoolean(TestContext.DataRow["result"]);
            int num = Convert.ToInt32(TestContext.DataRow["numToTest"]);

            // Act
            actual = PrimeUtils.IsPrime(num);

            // Assert
            Assert.AreEqual(expected, actual, "expected " + expected + " but got " + actual);
        }
    }
}
