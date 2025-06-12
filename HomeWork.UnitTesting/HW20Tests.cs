using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW20Tests
    {

        private TestContext testContext;

        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }



        [TestMethod]
        public void IsSpecial_StringIsAAAaa_ReturnsFalse()
        {
            // Arrange
            bool actual, expected;
            string str = "AAAaa";

            // Act
            expected = false;
            actual = HW20.IsSpecial(str);


            // Assert
            Assert.AreEqual(expected, actual, "Expected " + expected + " but got " + actual);
        }


        [DataTestMethod]
        [DataRow(null, false, DisplayName = "IsSpecial_StrIsNull_ReturnsFalse")]
        [DataRow("", false, DisplayName = "IsSpecial_StrIsEmpty_ReturnsFalse")]
        [DataRow("12@34%!56", false, DisplayName = "IsSpecial_StrIsNotLetters_ReturnsFalse")]
        [DataRow("AbC23cBa1@", true, DisplayName = "IsSpecial_StrIsValid_ReturnsTrue")]
        [DataRow("AbC23CBa1@", false, DisplayName = "IsSpecial_StrIsInvalid_ReturnsFalse")]
        public void IsSpecial_DataRow(string str, bool expected)
        {
            // Arrange
            bool actual;

            // Act
            actual = HW20.IsSpecial(str);

            // Assert
            Assert.AreEqual(expected, actual, "Expected " + expected + " but got " + actual);

        }


        [DataTestMethod]
        [DynamicData("IsSpecialTestGenerator", DynamicDataSourceType.Method)]
        public void IsSpecial_DynamicData(string str, bool expected)
        {
            // Arrange
            bool actual;

            // Act
            actual = HW20.IsSpecial(str);

            // Assert
            Assert.AreEqual(expected, actual, "Expected " + expected + " but got " + actual);

        }

        public static object[][] IsSpecialTestGenerator()
        {
            return new[]
            {
                new object[] {null,false},
                new object[] {"" , false},
                new object[] {"12@34%!56" , false},
                new object[] {"AbC23cBa1@" , true},
                new object[] {"AbC23CBa1@" , false},

            };
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    @"|DataDirectory|\XMLTests\HW20Tests.xml", "IsSpecialTests", DataAccessMethod.Sequential)]
        public void IsSpecial_XML()
        {
            // Arrange
            bool actual;
            string str = Convert.ToString(TestContext.DataRow["str"]);
            bool expected = Convert.ToBoolean(TestContext.DataRow["expectedResult"]);

            // Act
            actual = HW20.IsSpecial(str);

            // Assert
            Assert.AreEqual(expected, actual, "Expected " + expected + " but got " + actual);

        }

    }
}
