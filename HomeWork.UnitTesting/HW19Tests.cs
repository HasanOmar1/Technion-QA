using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW19Tests
    {
        [DataTestMethod]
        [DataRow(30, 20, 0, 20, DisplayName = "Clock_Hour=30,Min=20_ExpectedHour=0,ExpectedMin=20")]
        [DataRow(60, 70, 0, 0, DisplayName = "Clock_Hour=60,Min=70_ExpectedHour=0,ExpectedMin=0")]
        [DataRow(2, 88, 2, 0, DisplayName = "Clock_Hour=2,Min=88_ExpectedHour=2,ExpectedMin=0")]

        public void Clock_DataRow(int hour, int min, int expectedHour, int expectedMin)
        {
            // Arrange
            HW18Clock actual;

            // Act
            actual = new HW18Clock(hour, min);


            // Assert
            Assert.AreEqual(expectedHour, actual.GetHour(), "Expected hour to be " + expectedHour + " but got " + actual.GetHour());
            Assert.AreEqual(expectedMin, actual.GetMin(), "Expected minutes to be " + expectedMin + " but got " + actual.GetMin());

        }

        [DataTestMethod]
        [DynamicData("ClockTestGenerator", DynamicDataSourceType.Method)]

        public void Clock_DynamicData(int hour, int min, int expectedHour, int expectedMin)
        {
            // Arrange
            HW18Clock actual;

            // Act
            actual = new HW18Clock(hour, min);


            // Assert
            Assert.AreEqual(expectedHour, actual.GetHour(), "Expected hour to be " + expectedHour + " but got " + actual.GetHour());
            Assert.AreEqual(expectedMin, actual.GetMin(), "Expected minutes to be " + expectedMin + " but got " + actual.GetMin());

        }

        public static object[][] ClockTestGenerator()
        {
            return new[]
            {

                new object[] {30,20,0,20},
                new object[] {60,70,0,0 },
                new object[] {2,88,2,0}
            };
        }


        [DataTestMethod]
        [DynamicData("WhichClockIsEarlierTestGenerator", DynamicDataSourceType.Method)]
        public void Clock_WhichClockIsEarlier_DynamicData(HW18Clock[] clocks, HW18Clock expectedClock)
        {
            // Arrange
            HW18Clock actual;

            // Act
            actual = HW18Clock.WhichClockIsEarlier(clocks);

            // Assert
            if (expectedClock == null && actual == null)
            {
                Assert.IsTrue(true);
                return;
            }

            if (expectedClock != null && actual == null)
                Assert.Fail("Should not return null but we got null");

            if (expectedClock == null && actual != null)
                Assert.Fail("Should return null but we didnt get null");

            Assert.AreEqual(expectedClock.GetHour(), actual.GetHour(), "Error in hour");
            Assert.AreEqual(expectedClock.GetMin(), actual.GetMin(), "Error in minutes");

        }

        public static object[][] WhichClockIsEarlierTestGenerator()
        {
            HW18Clock c1 = new HW18Clock(5, 30);
            HW18Clock c2 = new HW18Clock(1, 30);
            HW18Clock c3 = new HW18Clock(11, 40);

            HW18Clock[] clocks = { c1, c2, c3 };

            return new[]
            {
                new object[] {clocks , c2},
                new object[] {null , null },
                new object[] {new HW18Clock[] {}, null }

            };
        }



        [TestMethod]
        public void Clock_WhichClockIsEarlier_ValidArr_ReturnsValidData()
        {
            // Arrange
            HW18Clock actual, expectedClock;

            HW18Clock c1 = new HW18Clock(5, 30);
            HW18Clock c2 = new HW18Clock(1, 30);
            HW18Clock c3 = new HW18Clock(11, 40);

            HW18Clock[] clocks = { c1, c2, c3 };

            // Act
            actual = HW18Clock.WhichClockIsEarlier(clocks);
            expectedClock = c2;


            // Assert
            if (expectedClock == null && actual == null)
            {
                Assert.IsTrue(true);
                return;
            }

            if (expectedClock != null && actual == null)
                Assert.Fail("Should not return null but we got null");

            if (expectedClock == null && actual != null)
                Assert.Fail("Should return null but we didnt get null");

            Assert.AreEqual(expectedClock.GetHour(), actual.GetHour(), "Error in hour");
            Assert.AreEqual(expectedClock.GetMin(), actual.GetMin(), "Error in minutes");

        }



        [TestMethod]
        public void Clock_WhichClockIsEarlier_ArrIsNull_ReturnsNull()
        {
            // Arrange
            HW18Clock actual, expectedClock;
            HW18Clock[] clocks = null;

            // Act
            actual = HW18Clock.WhichClockIsEarlier(clocks);
            expectedClock = null;


            // Assert
            if (expectedClock == null && actual == null)
            {
                Assert.IsTrue(true);
                return;
            }

            if (expectedClock != null && actual == null)
                Assert.Fail("Should not return null but we got null");

            if (expectedClock == null && actual != null)
                Assert.Fail("Should return null but we didnt get null");

            Assert.AreEqual(expectedClock.GetHour(), actual.GetHour(), "Error in hour");
            Assert.AreEqual(expectedClock.GetMin(), actual.GetMin(), "Error in minutes");

        }

        [TestMethod]
        public void Clock_WhichClockIsEarlier_ArrIsEmpty_ReturnsNull()
        {
            // Arrange
            HW18Clock actual, expectedClock;
            HW18Clock[] clocks = { };

            // Act
            actual = HW18Clock.WhichClockIsEarlier(clocks);
            expectedClock = null;


            // Assert
            if (expectedClock == null && actual == null)
            {
                Assert.IsTrue(true);
                return;
            }

            if (expectedClock != null && actual == null)
                Assert.Fail("Should not return null but we got null");

            if (expectedClock == null && actual != null)
                Assert.Fail("Should return null but we didnt get null");

            Assert.AreEqual(expectedClock.GetHour(), actual.GetHour(), "Error in hour");
            Assert.AreEqual(expectedClock.GetMin(), actual.GetMin(), "Error in minutes");

        }
    }
}
