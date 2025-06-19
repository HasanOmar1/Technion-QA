using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Objects.UnitTests
{
    [TestClass]
    public class ClockTests
    {

        private TestContext context;
        public TestContext TestContext
        {
            get { return context; }
            set { context = value; }
        }

        // Write a testMethod that verifies the ctor functionlity 
        // in case it is triggered with illegal values:
        // color = null (we expect the code to consider it as 'White!')
        // hour = -45 (we expect the code to consider it as 0)
        // min = 34 (we expect the code to consider it as 34)
        [TestMethod]
        public void Ctor2_ColorNullNegativeHour_ReturnsSpecialWhiteClockWith0AsHour()
        {
            // Arrange
            string color = null,
                    expectedColor = "White!";
            int hour = -45,
                    expectedHour = 0,
                    min = 34,
                    expectedMin = 34;
            Clock actual;

            // Act
            actual = new Clock(color, hour, min);

            // Assert
            Assert.AreEqual(expectedColor, actual.getColor(), "Bug in color");
            Assert.AreEqual(expectedHour, actual.getHour(), "Bug in hour");
            Assert.AreEqual(expectedMin, actual.getMin(), "Bug in min");
        }

        // Write a testMethod that verifies the ctor functionlity 
        // in case it is triggered with legal values:
        // color = "Red" (we expect the code to consider it as 'Red')
        // hour = 9 (we expect the code to consider it as 9)
        // min = 2 (we expect the code to consider it as 2)
        [TestMethod]
        public void Ctor2_ValidValues_ReturnsClockWithTheValidValues()
        {
            // Arrange
            string color = "Red",
                    expectedColor = "Red";
            int hour = 9,
                    expectedHour = 9,
                    min = 2,
                    expectedMin = 2;
            Clock actual;

            // Act
            actual = new Clock(color, hour, min);

            // Assert
            Assert.AreEqual(expectedColor, actual.getColor(), "Bug in color");
            Assert.AreEqual(expectedHour, actual.getHour(), "Bug in hour");
            Assert.AreEqual(expectedMin, actual.getMin(), "Bug in min");
        }


        [TestMethod]
        [DataRow("Red", "Red", 9, 9, 2, 2, DisplayName = "Ctor2_ValidValues_ReturnsClockWithTheValidValues")]
        [DataRow(null, "White!", -45, 0, 34, 34, DisplayName = "Ctor2_ColorNullNegativeHour_ReturnsSpecialWhiteClockWith0AsHour")]
        public void Ctor2(string color, string expectedColor,
                         int hour, int expectedHour,
                         int min, int expectedMin)
        {
            // Arrange
            Clock actual;

            // Act
            actual = new Clock(color, hour, min);

            // Assert
            Assert.AreEqual(expectedColor, actual.getColor(), "Bug in color");
            Assert.AreEqual(expectedHour, actual.getHour(), "Bug in hour");
            Assert.AreEqual(expectedMin, actual.getMin(), "Bug in min");
        }


        [TestMethod]
        [DynamicData("ctor2TestGenerator", DynamicDataSourceType.Method)]
        public void ctor2_Dynamic(string color, string expectedColor,
                                    int hour, int expectedHour,
                                    int min, int expectedMin)
        {
            // Arrange
            Clock actual;

            // Act
            actual = new Clock(color, hour, min);

            // Assert
            Assert.AreEqual(expectedColor, actual.getColor(), "Bug in color");
            Assert.AreEqual(expectedHour, actual.getHour(), "Bug in hour");
            Assert.AreEqual(expectedMin, actual.getMin(), "Bug in min");

        }

        public static object[][] ctor2TestGenerator()
        {

            return new[]
            {
                new object[]{"Red"  , "Red"     , 9     , 9, 2  , 2 },// Test1
                new object[]{null   , "White!"  , -34   , 0, 12 , 12} // Test2
            };
        }


        [TestMethod]
        [DataRow(new object[] { 13, 36 },
                 new object[] { 13, 36, "White!" },
                DisplayName = "ctor1_ValidValues_ReturnClockWithSameValues")]
        [DataRow(new object[] { 13, 36, "Purple" },
                 new object[] { 13, 36, "Purple" },
                DisplayName = "ctor2_ValidValues_ReturnClockWithSameValues")]
        [DataRow(new object[] { -13, -36, null },
                 new object[] { 0, 0, "White!" },
                DisplayName = "ctor2_InvalidValues_ReturnClockWithDefaultValues")]
        public void ctors(object[] userData, object[] expectedData)
        {
            // Arrange
            Clock actual;

            int hour = Convert.ToInt32(userData[0]),
                expectedHour = Convert.ToInt32(expectedData[0]);
            int min = Convert.ToInt32(userData[1]),
                expectedMin = Convert.ToInt32(expectedData[1]);
            string expectedColor = Convert.ToString(expectedData[2]);
            string color;

            // Act
            if (userData.Length == 3)
            {
                color = Convert.ToString(userData[2]);
                actual = new Clock(color, hour, min);
            }
            else
                actual = new Clock(hour, min);

            // Assert
            Assert.IsTrue(expectedColor == actual.getColor(), "BUG: in color");
            Assert.IsTrue(expectedHour == actual.getHour(), "BUG: in hour");
            Assert.IsTrue(expectedMin == actual.getMin(), "BUG: in min");
        }

        [TestMethod]
        [DynamicData("ctorsTestGenerator", DynamicDataSourceType.Method)]
        public void ctors_FromDynamic(object[] userData, object[] expectedData)
        {
            // Arrange
            Clock actual;

            int hour = Convert.ToInt32(userData[0]),
                expectedHour = Convert.ToInt32(expectedData[0]);
            int min = Convert.ToInt32(userData[1]),
                expectedMin = Convert.ToInt32(expectedData[1]);
            string expectedColor = Convert.ToString(expectedData[2]);
            string color;

            // Act
            if (userData.Length == 3)
            {
                color = Convert.ToString(userData[2]);
                actual = new Clock(color, hour, min);
            }
            else
                actual = new Clock(hour, min);

            // Assert
            Assert.IsTrue(expectedColor == actual.getColor(), "BUG: in color");
            Assert.IsTrue(expectedHour == actual.getHour(), "BUG: in hour");
            Assert.IsTrue(expectedMin == actual.getMin(), "BUG: in min");
        }

        public static object[][] ctorsTestGenerator()
        {
            return new[]
            {
                new object[]{
                                new object[] {13, 36},
                                new object[] {13, 36, "White!"}
                            },// Test1
                new object[]{
                                new object[] { 13, 36, "Purple" },
                                new object[] { 13, 36, "Purple" }
                            }, // Test2
                new object[]{
                                new object[] { -13, -36, null },
                                new object[] { 0, 0, "White!" }
                            }, // Test3
            };
        }


        [TestMethod]
        [DynamicData("getInfoTestGenerator", DynamicDataSourceType.Method)]
        public void getInfo_Dynamic(Clock clockToTest, object[] expected)
        {
            // Arrange
            object[] actual;

            // Act
            actual = Clock.getInfo(clockToTest);

            // Assert

            if (expected == null && actual == null)
                return;

            if (expected != null && actual == null)
                Assert.Fail("BUG: you should not get null in this case");

            if (expected == null && actual != null)
                Assert.Fail("BUG: you should get null in this case");

            // if the code came here then both actual and expected have the same len
            Assert.AreEqual(expected.Length, actual.Length, "BUG: the output array doesn't have the correct len");

            // לבדוק תוכן תאים
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Bug in item #" + i);

        }

        public static object[][] getInfoTestGenerator()
        {
            return new[]
            {
                new object[]{
                                new Clock(14, 57),
                                new object[]{"White!", 14, 57}
                            },// Test1
                new object[]{
                                new Clock(14, -57),
                                new object[]{"White!", 14, 0}
                            }, // Test2
                new object[]{
                                new Clock(null, -4314, -57),
                                new object[]{"White!", 0, 0}
                            }, // Test3
                new object[]{
                                new Clock("Black", 15, 5),
                                new object[]{ "Black", 15, 5 }
                            } // Test4
            };
        }



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    @"|DataDirectory|\XMLTests\ClockTests.xml",
                    "Ctor2Test",
                    DataAccessMethod.Random)]
        public void Ctor2TestsFromXML()
        {
            // Arrange
            Clock actual;

            string color = Convert.ToString(TestContext.DataRow["color"]),
                   expectedColor = Convert.ToString(TestContext.DataRow["expectedColor"]);
            int hour = Convert.ToInt32(TestContext.DataRow["hour"]),
                expectedHour = Convert.ToInt32(TestContext.DataRow["expectedHour"]);
            int min = Convert.ToInt32(TestContext.DataRow["min"]),
                expectedMin = Convert.ToInt32(TestContext.DataRow["expectedMin"]);

            // Act
            actual = new Clock(color, hour, min);

            // Assert
            Assert.AreEqual(expectedColor, actual.getColor(), "BUG in color");
            Assert.AreEqual(expectedHour, actual.getHour(), "BUG in hour");
            Assert.AreEqual(expectedMin, actual.getMin(), "BUG in min");
        }

    }
}
