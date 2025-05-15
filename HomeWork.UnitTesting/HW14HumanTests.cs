using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW14HumanTests
    {
        [TestMethod]
        public void Ctor1_Human_ValidInputs_ReturnsRelevantData()
        {
            // Arrange
            string name = "hasan";
            string eyesColor = "green";
            string skinColor = "cyan";
            HW14Human human;

            // Act
            human = new HW14Human(name, eyesColor, skinColor);

            // Assert
            Assert.AreEqual(name, human.getName(), "Error in name");
            Assert.AreEqual(eyesColor, human.getEyesColor(), "Error in eyes color");
            Assert.AreEqual(skinColor, human.getSkinColor(), "Error in skin color");

        }

        [TestMethod]
        public void Ctor1_Human_NameIsNull_ReturnsNameAnonymous()
        {
            // Arrange
            string name = null , expectedName = "anonymous";
            string eyesColor = "green";
            string skinColor = "cyan";
            HW14Human human;

            // Act
            human = new HW14Human(name, eyesColor, skinColor);

            // Assert
            Assert.AreEqual(expectedName, human.getName(), "Error in name");
            Assert.AreEqual(eyesColor, human.getEyesColor(), "Error in eyes color");
            Assert.AreEqual(skinColor, human.getSkinColor(), "Error in skin color");

        }

        [TestMethod]
        public void Ctor1_Human_AllParamsAreNull_ReturnsAllDefaultValues()
        {
            // Arrange
            string name = null, expectedName = "anonymous";
            string eyesColor = null, expectedEyesColor = "brown";
            string skinColor = null, expectedSkinColor = "green";
            HW14Human human;

            // Act
            human = new HW14Human(name, eyesColor, skinColor);

            // Assert
            Assert.AreEqual(expectedName, human.getName(), "Error in name");
            Assert.AreEqual(expectedEyesColor, human.getEyesColor(), "Error in eyes color");
            Assert.AreEqual(expectedSkinColor, human.getSkinColor(), "Error in skin color");

        }

        [TestMethod]
        [DataRow("hasan", "green", "cyan", "hasan", "green", "cyan", DisplayName = "Ctor1_Human_ValidInputs_ReturnsRelevantData")]
        [DataRow(null, "green", "cyan", "anonymous", "green", "cyan", DisplayName = "Ctor1_Human_NameIsNull_ReturnsNameAnonymous")]
        [DataRow(null, null, null, "anonymous", "brown", "green", DisplayName = "Ctor1_Human_AllParamsAreNull_ReturnsAllDefaultValues")]
        public void Ctor1_Human(string name, string eyesColor, string skinColor, string expectedName, string expectedEyesColor, string expectedSkinColor)
        {
            // Arrange
            HW14Human human;

            // Act
            human = new HW14Human(name, eyesColor, skinColor);

            // Assert
            Assert.AreEqual(expectedName, human.getName(), "Error in name");
            Assert.AreEqual(expectedEyesColor, human.getEyesColor(), "Error in eyes color");
            Assert.AreEqual(expectedSkinColor, human.getSkinColor(), "Error in skin color");

        }

       

      

        [TestMethod]
        public void Ctor2_Human_ValidInputs_ReturnsRelevantData()
        {
            // Arrange
            string name = "hasan";
            string eyesColor = "green";
            string expectedSkinColor = "green";
            HW14Human human;

            // Act
            human = new HW14Human(name,eyesColor);

            // Assert
            Assert.AreEqual(name, human.getName(), "Error in name");
            Assert.AreEqual(eyesColor, human.getEyesColor(), "Error in eyes color");
            Assert.AreEqual(expectedSkinColor, human.getSkinColor(), "Error in skin color");

        }

        [TestMethod]
        public void Ctor2_Human_NameIsNull_ReturnsNameAnonymous()
        {
            // Arrange
            string name = null , expectedName = "anonymous";
            string eyesColor = "gold";
            string expectedSkinColor = "green";
            HW14Human human;

            // Act
            human = new HW14Human(name,eyesColor);

            // Assert
            Assert.AreEqual(expectedName, human.getName(), "Error in name");
            Assert.AreEqual(eyesColor, human.getEyesColor(), "Error in eyes color");
            Assert.AreEqual(expectedSkinColor, human.getSkinColor(), "Error in skin color");

        }

        [TestMethod]
        public void Ctor2_Human_AllParamsAreNull_ReturnsAllDefaultValues()
        {
            // Arrange
            string name = null, expectedName = "anonymous";
            string eyesColor = null, expectedEyesColor = "brown";
            string expectedSkinColor = "green";
            HW14Human human;

            // Act
            human = new HW14Human(name, eyesColor);

            // Assert
            Assert.AreEqual(expectedName, human.getName(), "Error in name");
            Assert.AreEqual(expectedEyesColor, human.getEyesColor(), "Error in eyes color");
            Assert.AreEqual(expectedSkinColor, human.getSkinColor(), "Error in skin color");

        }


        [TestMethod]
        [DataRow("hasan", "green", "hasan", "green", "green", DisplayName = "Ctor2_Human_ValidInputs_ReturnsRelevantData")]
        [DataRow(null, "gold", "anonymous", "gold", "green", DisplayName = "Ctor2_Human_NameIsNull_ReturnsNameAnonymous")]
        [DataRow(null, null, "anonymous", "brown", "green", DisplayName = "Ctor2_Human_AllParamsAreNull_ReturnsAllDefaultValues")]
        public void Ctor2_Human(string name, string eyesColor, string expectedName, string expectedEyesColor, string expectedSkinColor)
        {
            // Arrange
            HW14Human human;

            // Act
            human = new HW14Human(name, eyesColor);

            // Assert
            Assert.AreEqual(expectedName, human.getName(), "Error in name");
            Assert.AreEqual(expectedEyesColor, human.getEyesColor(), "Error in eyes color");
            Assert.AreEqual(expectedSkinColor, human.getSkinColor(), "Error in skin color");

        }



        [TestMethod]
        [DataRow("hasan" , "green" , "cyan" , "hasan" , "green" , "cyan" , "ctorAllParams", DisplayName = "Ctor1_Human_ValidInputs_ReturnsRelevantData")]
        [DataRow(null, "green", "cyan", "anonymous", "green", "cyan", "ctorAllParams", DisplayName = "Ctor1_Human_NameIsNull_ReturnsNameAnonymous")]
        [DataRow(null, null, null, "anonymous", "brown", "green", "ctorAllParams", DisplayName = "Ctor1_Human_AllParamsAreNull_ReturnsAllDefaultValues")]

        [DataRow("hasan", "green", "---", "hasan", "green", "green", "ctorTwoParams", DisplayName = "Ctor2_Human_ValidInputs_ReturnsRelevantData")]
        [DataRow(null, "gold", "---" ,"anonymous", "gold", "green", "ctorTwoParams" , DisplayName = "Ctor2_Human_NameIsNull_ReturnsNameAnonymous")]
        [DataRow(null, null, "---", "anonymous", "brown", "green", "ctorTwoParams", DisplayName = "Ctor2_Human_AllParamsAreNull_ReturnsAllDefaultValues")]
        public void Ctor1And2_Human(string name, string eyesColor , string skinColor , string expectedName, string expectedEyesColor, string expectedSkinColor , string ctor)
        {
            // Arrange
            HW14Human human;

            // Act
            human = new HW14Human(name, eyesColor, skinColor);

            if (ctor == "ctorTwoParams")
                human = new HW14Human(name, eyesColor);


            // Assert

            Assert.AreEqual(expectedName, human.getName(), "Error in name");
            Assert.AreEqual(expectedEyesColor, human.getEyesColor(), "Error in eyes color");
            Assert.AreEqual(expectedSkinColor, human.getSkinColor(), "Error in skin color");

        }
    }
}
