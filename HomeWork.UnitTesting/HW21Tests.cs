using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW21Tests
    {

        private TestContext testContext;

        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    @"|DataDirectory|\XMLTests\HW21Tests.xml",
            "IsSpecialString", DataAccessMethod.Sequential)]
        public void IsSpecial_XML()
        {
            // Arrange
            bool actual;
            bool expected = Convert.ToBoolean(TestContext.DataRow["expectedResult"]);
            string str = Convert.ToString(TestContext.DataRow["string"]);

            // Act
            actual = HW21.isSpecial(str);

            // Assert
            Assert.AreEqual(expected, actual, "Expected " + expected + " but got " + actual);


        }
    }
}
