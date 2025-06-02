using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW17Tests
    {
        [TestMethod]
        [DynamicData("HeaviestBoxTestGenerator", DynamicDataSourceType.Method)]
        public void HeaviestBox_DynamicData(HW15Box[] boxes, string expected)
        {
            // Arrange
            string actual;

            // Act
            actual = HW15Box.HeaviestBox(boxes);

            // Assert
            Assert.AreEqual(expected, actual, "Should return " + expected + " but got " + actual);
        }

        public static object[][] HeaviestBoxTestGenerator()
        {
            return new[] {
                new object []{ new HW15Box[] { new HW15Box("red" , 10) , new HW15Box("blue" , 5) } , "red" },
                new object []{ new HW15Box[] { new HW15Box(null , 10) , new HW15Box("blue" , 5) } , "white" },
                new object []{ new HW15Box[] { new HW15Box("red" , 10) , new HW15Box("blue" , 51) } , "blue" },

            };
        }

        [TestMethod]
        [DynamicData("GetBoxesInRangeTestGenerator", DynamicDataSourceType.Method)]
        public void GetBoxesInRange_DynamicData(HW15Box[] arr, int min, int max, HW15Box[] expected)
        {

            // Arrange
            HW15Box[] actual;

            // Act
            actual = HW15Box.GetBoxesInRange(arr, min, max);

            // Assert

            if (expected == null && actual == null)
            {
                Assert.IsTrue(true);
                return;
            }

            if (expected == null && actual != null)
                Assert.Fail("Expected null but didnt get null");

            if (expected != null && actual == null)
                Assert.Fail("Expected not null but got null");

            Assert.AreEqual(expected.Length, actual.Length, "Error in length");

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].GetColor(), actual[i].GetColor(), "Error in color at index #" + i);
                Assert.AreEqual(expected[i].GetLen(), actual[i].GetLen(), "Error in length at index #" + i);
                Assert.AreEqual(expected[i].GetWidth(), actual[i].GetWidth(), "Error in width at index #" + i);
                Assert.AreEqual(expected[i].GetHeight(), actual[i].GetHeight(), "Error in height at index #" + i);
                Assert.AreEqual(expected[i].GetWeight(), actual[i].GetWeight(), "Error in weight at index #" + i);

            }
        }

        public static object[][] GetBoxesInRangeTestGenerator()
        {
            HW15Box box1 = new HW15Box(null, 3, 4, 5, 10);
            HW15Box box2 = new HW15Box("red", 4, 5, 6, 10);
            HW15Box box3 = new HW15Box("black", 6, 7, 8, 10);

            HW15Box[] arr = { box1, box2, box3 };

            return new[]
            {
                new object[] {arr , 50,130 , new HW15Box[] { box1,box2} },
                new object[] {null , 50,130 , null },
                new object[] {arr ,10,20 , new HW15Box[] { } }
            };
        }
    }
}
