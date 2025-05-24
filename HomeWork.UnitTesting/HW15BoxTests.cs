using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW15BoxTests
    {


        [TestMethod]
        public void Ctor1_ValidInputs_ReturnsValidData()
        {
            // Arrange
            HW15Box box;
            string color = "green", expectedColor = "green";
            int len = 5, expectedLen = 5;
            int width = 10, expectedWidth = 10;
            int height = 20, expectedHeight = 20;
            double weight = 30, expectedWeight = 30;


            // Act
            box = new HW15Box(color, len, width, height, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");


        }

        [TestMethod]
        public void Ctor1_ColorIsNull_ReturnsWhiteColor()
        {
            // Arrange
            HW15Box box;
            string color = null, expectedColor = "white";
            int len = 5, expectedLen = 5;
            int width = 10, expectedWidth = 10;
            int height = 20, expectedHeight = 20;
            double weight = 30, expectedWeight = 30;


            // Act
            box = new HW15Box(color, len, width, height, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");


        }

        [TestMethod]
        public void Ctor1_InvalidLenAndWidth_Returns1LenAnd1Width()
        {
            // Arrange
            HW15Box box;
            string color = "black", expectedColor = "black";
            int len = -5, expectedLen = 1;
            int width = -12, expectedWidth = 1;
            int height = 20, expectedHeight = 20;
            double weight = 30, expectedWeight = 30;


            // Act
            box = new HW15Box(color, len, width, height, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");


        }

        [TestMethod]
        public void Ctor1_InvalidInputs_ReturnsDefaultValues()
        {
            // Arrange
            HW15Box box;
            string color = null, expectedColor = "white";
            int len = -5, expectedLen = 1;
            int width = -12, expectedWidth = 1;
            int height = -20, expectedHeight = 1;
            double weight = -30, expectedWeight = 1;


            // Act
            box = new HW15Box(color, len, width, height, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");


        }

        [TestMethod]
        public void Ctor2_ValidInputs_ReturnsValidData()
        {
            // Arrange
            HW15Box box;
            string color = "green", expectedColor = "green";
            int expectedLen = 1;
            int expectedWidth = 1;
            int expectedHeight = 1;
            double weight = 30, expectedWeight = 30;


            // Act
            box = new HW15Box(color, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");

        }

        [TestMethod]
        public void Ctor2_ColorIsNull_ReturnsWhiteColor()
        {
            // Arrange
            HW15Box box;
            string color = null, expectedColor = "white";
            int expectedLen = 1;
            int expectedWidth = 1;
            int expectedHeight = 1;
            double weight = 30, expectedWeight = 30;


            // Act
            box = new HW15Box(color, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");

        }

        [TestMethod]
        public void Ctor2_ColorIsEmptyString_ReturnsWhiteColor()
        {
            // Arrange
            HW15Box box;
            string color = "", expectedColor = "white";
            int expectedLen = 1;
            int expectedWidth = 1;
            int expectedHeight = 1;
            double weight = 30, expectedWeight = 30;


            // Act
            box = new HW15Box(color, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");

        }

        [TestMethod]
        public void Ctor2_InvalidWeight_Returns1Weight()
        {
            // Arrange
            HW15Box box;
            string color = "green", expectedColor = "green";
            int expectedLen = 1;
            int expectedWidth = 1;
            int expectedHeight = 1;
            double weight = -30, expectedWeight = 1;


            // Act
            box = new HW15Box(color, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");

        }

        [DataTestMethod]
        [DataRow("green", 5, 10, 20, 30, "green", 5, 10, 20, 30, DisplayName = "Ctor1_ValidInputs_ReturnsValidData")]
        [DataRow(null, 5, 10, 20, 30, "white", 5, 10, 20, 30, DisplayName = "Ctor1_ColorIsNull_ReturnsWhiteColor")]
        [DataRow("black", -5, -12, 20, 30, "black", 1, 1, 20, 30, DisplayName = "Ctor1_InvalidLenAndWidth_Returns1LenAnd1Width")]
        [DataRow(null, -5, -12, -20, -30, "white", 1, 1, 1, 1, DisplayName = "Ctor1_InvalidInputs_ReturnsDefaultValues")]
        public void Ctor1(string color, int len, int width, int height, int weight, string expectedColor, int expectedLen, int expectedWidth, int expectedHeight, double expectedWeight)
        {
            // Arrange
            HW15Box box;


            // Act
            box = new HW15Box(color, len, width, height, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");

        }



        [DataTestMethod]
        [DataRow("green", 30, "green", 1, 1, 1, 30, DisplayName = "Ctor2_ValidInputs_ReturnsValidData")]
        [DataRow(null, 30, "white", 1, 1, 1, 30, DisplayName = "Ctor2_ColorIsNull_ReturnsWhiteColor")]
        [DataRow("", 30, "white", 1, 1, 1, 30, DisplayName = "Ctor2_ColorIsEmptyString_ReturnsWhiteColor")]
        [DataRow("green", -30, "green", 1, 1, 1, 1, DisplayName = "Ctor2_InvalidWeight_Returns1Weight")]
        public void Ctor2(string color, int weight, string expectedColor, int expectedLen, int expectedWidth, int expectedHeight, double expectedWeight)
        {
            // Arrange
            HW15Box box;


            // Act
            box = new HW15Box(color, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");


        }


        [DataTestMethod]
        [DataRow("green", 5, 10, 20, 30, "green", 5, 10, 20, 30, DisplayName = "Ctor1_ValidInputs_ReturnsValidData")]
        [DataRow(null, 5, 10, 20, 30, "white", 5, 10, 20, 30, DisplayName = "Ctor1_ColorIsNull_ReturnsWhiteColor")]
        [DataRow("black", -5, -12, 20, 30, "black", 1, 1, 20, 30, DisplayName = "Ctor1_InvalidLenAndWidth_Returns1LenAnd1Width")]
        [DataRow(null, -5, -12, -20, -30, "white", 1, 1, 1, 1, DisplayName = "Ctor1_InvalidInputs_ReturnsDefaultValues")]
        [DataRow("green", 0, 0, 0, 30, "green", 1, 1, 1, 30, 2, DisplayName = "Ctor2_ValidInputs_ReturnsValidData")]
        [DataRow(null, 0, 0, 0, 30, "white", 1, 1, 1, 30, 2, DisplayName = "Ctor2_ColorIsNull_ReturnsWhiteColor")]
        [DataRow("", 0, 0, 0, 30, "white", 1, 1, 1, 30, 2, DisplayName = "Ctor2_ColorIsEmptyString_ReturnsWhiteColor")]
        [DataRow("green", 0, 0, 0, -30, "green", 1, 1, 1, 1, 2, DisplayName = "Ctor2_InvalidWeight_Returns1Weight")]
        public void Ctors(string color, int len, int width, int height, int weight, string expectedColor, int expectedLen, int expectedWidth, int expectedHeight, double expectedWeight, int ctorNum = 1)
        {
            // Arrange
            HW15Box box;


            // Act
            box = new HW15Box(color, len, width, height, weight);

            if (ctorNum == 2)
                box = new HW15Box(color, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");


        }


        [DataTestMethod]
        [DataRow(new object[] { "green", 5, 10, 20, 30 }, new object[] { "green", 5, 10, 20, 30 }, DisplayName = "Ctor1_ValidInputs_ReturnsValidData")]
        [DataRow(new object[] { null, 5, 10, 20, 30 }, new object[] { "white", 5, 10, 20, 30 }, DisplayName = "Ctor1_ColorIsNull_ReturnsWhiteColor")]
        [DataRow(new object[] { "black", -5, -12, 20, 30 }, new object[] { "black", 1, 1, 20, 30 }, DisplayName = "Ctor1_InvalidLenAndWidth_Returns1LenAnd1Width")]
        [DataRow(new object[] { null, -5, -12, -20, -30 }, new object[] { "white", 1, 1, 1, 1 }, DisplayName = "Ctor1_InvalidInputs_ReturnsDefaultValues")]
        [DataRow(new object[] { "green", 0, 0, 0, 30 }, new object[] { "green", 1, 1, 1, 30 }, 2, DisplayName = "Ctor2_ValidInputs_ReturnsValidData")]
        [DataRow(new object[] { null, 0, 0, 0, 30 }, new object[] { "white", 1, 1, 1, 30 }, 2, DisplayName = "Ctor2_ColorIsNull_ReturnsWhiteColor")]
        [DataRow(new object[] { "", 0, 0, 0, 30 }, new object[] { "white", 1, 1, 1, 30 }, 2, DisplayName = "Ctor2_ColorIsEmptyString_ReturnsWhiteColor")]
        [DataRow(new object[] { "green", 0, 0, 0, -30 }, new object[] { "green", 1, 1, 1, 1 }, 2, DisplayName = "Ctor2_InvalidWeight_Returns1Weight")]
        public void Ctors_WithObject(object[] boxData, object[] expected, int ctorNum = 1)
        {
            // Arrange
            HW15Box box;

            // actual
            string color = Convert.ToString(boxData[0]);
            int len = Convert.ToInt32(boxData[1]);
            int width = Convert.ToInt32(boxData[2]);
            int height = Convert.ToInt32(boxData[3]);
            double weight = Convert.ToDouble(boxData[4]);

            // expected
            string expectedColor = Convert.ToString(expected[0]);
            int expectedLen = Convert.ToInt32(expected[1]);
            int expectedWidth = Convert.ToInt32(expected[2]);
            int expectedHeight = Convert.ToInt32(expected[3]);
            double expectedWeight = Convert.ToDouble(expected[4]);

            // Act
            box = new HW15Box(color, len, width, height, weight);

            if (ctorNum == 2)
                box = new HW15Box(color, weight);

            // Assert
            Assert.AreEqual(expectedColor, box.GetColor(), "Error in Color");
            Assert.AreEqual(expectedLen, box.GetLen(), "Error in Length");
            Assert.AreEqual(expectedWidth, box.GetWidth(), "Error in Width");
            Assert.AreEqual(expectedHeight, box.GetHeight(), "Error in Height");
            Assert.AreEqual(expectedWeight, box.GetWeight(), "Error in Weight");


        }




        [TestMethod]
        public void A_ArrIsNull_ReturnsMinus1()
        {

            // Arrange
            int actual;
            HW15Box[] box = null;
            int expected = -1;

            // Act
            actual = HW15Box.A(box);

            // Assert
            Assert.AreEqual(expected, actual, "Should have returned " + expected);

        }

        [TestMethod]
        public void A_ArrIsEmpty_ReturnsMinus1()
        {

            // Arrange
            int actual;
            HW15Box[] box = { };
            int expected = -1;

            // Act
            actual = HW15Box.A(box);

            // Assert
            Assert.AreEqual(expected, actual, "Should have returned " + expected);

        }

        [TestMethod]
        public void A_ValidArr_Returns1()
        {

            // Arrange
            int actual;
            HW15Box box1 = new HW15Box("red", 5);
            HW15Box[] box = { box1 };
            int expected = 1;

            // Act
            actual = HW15Box.A(box);

            // Assert
            Assert.AreEqual(expected, actual, "Should have returned " + expected);

        }


        [TestMethod]
        public void B_ArrIsNull_ReturnsNull()
        {

            // Arrange
            HW15Box[] actual;
            HW15Box[] box = null, expected = null;

            // Act
            actual = HW15Box.B(box);

            // Assert
            Assert.AreEqual(expected, actual, "Should have returned null");
            Assert.IsNull(actual, "Should have returned null");

        }

        [TestMethod]
        public void B_ArrIsEmpty_ReturnsEmptyArr()
        {

            // Arrange
            HW15Box[] actual;
            HW15Box[] box = { };
            HW15Box[] expected = { };

            // Act
            actual = HW15Box.B(box);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length, "Bug in length of array");
            for (int i = 0; i < actual.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Bug at index #" + i);



        }

        [TestMethod]
        public void B_ValidArr_ReturnsValidData()
        {

            // Arrange
            HW15Box[] actual;

            HW15Box box1 = new HW15Box("red", 5);
            HW15Box box2 = new HW15Box("green", 5);

            HW15Box[] boxes = { box1, box2 }, expected = { box1, box2 };

            // Act
            actual = HW15Box.B(boxes);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length, "Bug in length of array");
            for (int i = 0; i < actual.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Bug at index #" + i);

        }

        //[DataTestMethod]
        //[DataRow(new object[] { null }, new object[] { -1 }, DisplayName = "A_ArrIsNull_ReturnsMinus1")]
        //public void A_Methods_WithObject(object[] boxData, object[] expected)
        //{
        //    // Arrange
        //    int actual;
        //    int box = Convert.ToInt32(boxData[0]), expectedBox = Convert.ToInt32(expected[0]);

        //    // Act
        //    actual = HW15Box.A(box);

        //    // Assert
        //    Assert.AreEqual(expectedBox, box, "Should return " + expected[0]);

        //}
    }
}
