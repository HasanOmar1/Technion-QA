using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW3Tests
    {

        private TestContext testContext;

        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }


        [TestMethod]
        public void calc_x100y200zTrue_Returns300()
        {
            // arrange
            int actual;
            int expected = 300;

            // act
            actual = HW3.calc(100, 200, true);

            // assert
            Assert.AreEqual(expected, actual, "I Should get " + expected + " but got " + actual);

        }
        [TestMethod]
        public void calc_x100y200zFalse_ReturnsMinus100()
        {
            // arrange
            int actual;
            int expected = -100;

            // act
            actual = HW3.calc(100, 200, false);

            // assert
            Assert.AreEqual(expected, actual, "I Should get " + expected + " but got " + actual);


        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"|DataDirectory|\XMLTests\HW3Tests.xml",
            "calcTest", DataAccessMethod.Sequential)]


        public void calc_XML()
        {
            // arrange
            int actual;
            int expected = Convert.ToInt32(TestContext.DataRow["result"]);

            int x = Convert.ToInt32(TestContext.DataRow["x"]);
            int y = Convert.ToInt32(TestContext.DataRow["y"]);
            bool z = Convert.ToBoolean(TestContext.DataRow["z"]);

            // act
            actual = HW3.calc(x, y, z);

            // assert
            Assert.AreEqual(expected, actual, "I Should get " + expected + " but got " + actual);
        }

    }
}
