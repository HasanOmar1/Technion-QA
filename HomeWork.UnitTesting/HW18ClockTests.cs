using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW18ClockTests
    {
        [DataTestMethod]
        [DynamicData("ClockTestGenerator", DynamicDataSourceType.Method)]
        public void Clock_GetInterval_DynamicData(int hour, int min, int expected)
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


        [DataTestMethod]
        [DataRow(7, 4, "07:04", DisplayName = " Clock_ToString_7Hour4Minutes_Returns07:04")]
        [DataRow(3, 51, "03:51", DisplayName = " Clock_ToString_3Hour51Minutes_Returns03:51")]
        [DataRow(14, 31, "14:31", DisplayName = " Clock_ToString_14Hour31Minutes_Returns14:31")]
        [DataRow(24, 13, "00:13", DisplayName = " Clock_ToString_24Hour13Minutes_Returns00:13")]
        [DataRow(24, 0, "00:00", DisplayName = " Clock_ToString_24Hour0Minutes_Returns00:00")]
        [DataRow(5, 70, "06:10", DisplayName = " Clock_ToString_5Hour70Minutes_Returns06:10")]
        [DataRow(30, 100, "07:40", DisplayName = " Clock_ToString_30Hour100Minutes_Returns07:40")]



        public void Clock_ToString_DataRow(int hour, int min, string expected)
        {
            // Arrange
            HW18Clock myCode = new HW18Clock(hour, min);
            string actual;

            // Act
            actual = myCode.ToString();

            // Assert
            Assert.AreEqual(expected, actual, "Should have returned " + expected + " but got " + actual);


        }


        [DataTestMethod]
        [DataRow(5, 10, 7, 40, true, DisplayName = "Clock_IsEarlier_5Hour10Min_7OtherHour40OtherMin_ReturnsTrue")]
        [DataRow(8, 30, 3, 10, false, DisplayName = "Clock_IsEarlier_8Hour30Min_3OtherHour10OtherMin_ReturnsFalse")]
        [DataRow(5, 10, 5, 10, false, DisplayName = "Clock_IsEarlier_5Hour10Min_5OtherHour10OtherMin_ReturnsFalse")]


        public void Clock_IsEarlier_DataRow(int hour, int min, int otherHour, int otherMin, bool expected)
        {
            // Arrange
            HW18Clock myCode = new HW18Clock(hour, min);
            HW18Clock other = new HW18Clock(otherHour, otherMin);
            bool actual;

            // Act
            actual = myCode.IsEarlier(other);

            // Assert
            Assert.AreEqual(expected, actual, "Should have returned " + expected + " but got " + actual);


        }


        [DataTestMethod]
        [DataRow(3, 10, 5, 3, 15, DisplayName = "Clock_Increment_3Hour10Min_N=5_NewTime3Hour15Min")]
        [DataRow(23, 50, 10, 0, 0, DisplayName = "Clock_Increment_23Hour50Min_N=10_NewTime0Hour0Min")]
        [DataRow(7, 0, 185, 10, 5, DisplayName = "Clock_Increment_7Hour0Min_N=185_NewTime10Hour5Min")]

        public void Clock_Increment_DataRow(int hour, int min, int n, int expectedHour, int expectedMin)
        {
            // Arrange
            HW18Clock actual = new HW18Clock(hour, min);
            HW18Clock expected = new HW18Clock(expectedHour, expectedMin);

            // Act
            actual.Increment(n);

            // Assert
            Assert.AreEqual(expected.GetHour(), actual.GetHour(), "Should have returned " + expected.GetHour() + " but got " + actual.GetHour());

            Assert.AreEqual(expected.GetMin(), actual.GetMin(), "Should have returned " + expected.GetMin() + " but got " + actual.GetMin());


        }
    }
}
