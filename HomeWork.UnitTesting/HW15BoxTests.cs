using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW15BoxTests
    {
        private string color;
        private int len;
        private int width;
        private int height;
        private double weight;



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

        }
    }
}
