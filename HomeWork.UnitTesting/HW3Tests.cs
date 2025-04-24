using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW3Tests
    {
        [TestMethod]
        public void calc_x100y200zTrue_Returns300()
        {
            // arrange
            int actual;
            int expected = 300;

            // act
            actual = HW3.calc(100, 200, true);

            // assert
            Assert.AreEqual(expected, actual , "I Should get " + expected + " but got " + actual);

        }

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


    }
}
