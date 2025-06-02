using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW2Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num1 = 9 + 10;
            int num2 = 19;
            Assert.AreEqual(num1, num2, "Error line 9 , " + num1 + " should equal " + num2);
        }

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    int num1 = 9 + 10;
        //    Assert.AreEqual(num1, 21, "Error line 18 , expected : " + num1 + " should be equal to 19");
        //}

    }
}
