using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW18ClockTests
    {
        [DataTestMethod]
        [DynamicData("ClockTestGenerator", DynamicDataSourceType.Method)]
        public void Clock_DynamicData(int hour, int min, int expected)
        {
            // Arrange
            HW18Clock myCode = new HW18Clock(hour, min);
            int actual;


            // Act
            actual = myCode.GetInterval();

            // Assert
            Assert.AreEqual(expected, actual, "Should have gotten " + expected + " but got " + actual);
        }

        public static object[][] ClockTestGenerator()
        {
            return new[]
            {
                new object[] {20 , 45 , 195},
                new object[] {23 , 59 , 1},
                new object[] {24 , 0 , 0},
                new object[] {31 , 5 , 0 },
                new object[] {0 , 0 , 1440}
            };
        }
    }
}
