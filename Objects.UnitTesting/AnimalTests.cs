using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Objects.UnitTesting
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void Ctro1_ValidValues_ReturnsRelevantAnimal()
        {

            // Arrange
            string type = "Cat";
            int age = 1;
            double weight = 2.5;

            Animal actual; ;

            // Act
            actual = new Animal(type, age, weight);

            // Assert
            Assert.AreEqual(type, actual.getAnimalType() , "Problem in Type");
            Assert.AreEqual(age, actual.getAge(), "Problem in Age");
            Assert.AreEqual(weight, actual.getWeight(), "Problem in Weight");


        }

        [TestMethod]
        public void Ctro1_NegativeAge_ReturnsAnimalWithAge0()
        {

            // Arrange
            string type = "Cat";
            int age = -1 , expectedAge = 0;
            double weight = 2.5;

            Animal actual; 

            // Act
            actual = new Animal(type, age, weight);

            // Assert
            Assert.AreEqual(type, actual.getAnimalType(), "Problem in Type");
            Assert.AreEqual(expectedAge, actual.getAge(), "Problem in Age");
            Assert.AreEqual(weight, actual.getWeight(), "Problem in Weight");


        }

        [TestMethod]
        public void Ctro1_IllegalValues_ReturnsDefaultAsExpected()
        {

            // Arrange
            string type = null , expectedType = "Lion";
            int age = -11, expectedAge = 0;
            double weight = -2.5 , expectedWeight = 1;
            
            Animal actual;

            // Act
            actual = new Animal(type, age, weight);

            // Assert
            Assert.AreEqual(expectedType, actual.getAnimalType(), "Problem in Type");
            Assert.AreEqual(expectedAge, actual.getAge(), "Problem in Age");
            Assert.AreEqual(expectedWeight, actual.getWeight(), "Problem in Weight");


        }


        [TestMethod]
        public void Ctro2_ValidValues_ReturnsRelevantAnimal()
        {

            // Arrange
            string type = "Cat";
            int expectedAge = 5;
            double expectedWeight = 250;

            Animal actual; ;

            // Act
            actual = new Animal(type);

            // Assert
            Assert.AreEqual(type, actual.getAnimalType(), "Problem in Type");
            Assert.AreEqual(expectedAge, actual.getAge(), "Problem in Age");
            Assert.AreEqual(expectedWeight, actual.getWeight(), "Problem in Weight");


        }

        [TestMethod]
        public void Ctro2_AnimalIsNull_ReturnsAnimalAsLionWithDefaults()
        {

            // Arrange
            string type = null , expectedType = "Lion";
            int expectedAge = 5;
            double expectedWeight = 250;

            Animal actual; ;

            // Act
            actual = new Animal(type);

            // Assert
            Assert.AreEqual(expectedType, actual.getAnimalType(), "Problem in Type");
            Assert.AreEqual(expectedAge, actual.getAge(), "Problem in Age");
            Assert.AreEqual(expectedWeight, actual.getWeight(), "Problem in Weight");


        }


    }
}
