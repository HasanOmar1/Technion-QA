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


        [DataTestMethod]
        [DataRow("Cat", 1 , 2.5 , "Cat" , 1 , 2.5 , DisplayName = "Ctro1_ValidValues_ReturnsRelevantAnimal")]
        [DataRow("Cat", -1, 2.5, "Cat", 0, 2.5, DisplayName = "Ctro1_NegativeAge_ReturnsAnimalWithAge0")]
        [DataRow(null, -11, -2.5, "Lion", 0, 1, DisplayName = "Ctro1_IllegalValues_ReturnsDefaultAsExpected")]

        public void Ctro1(string type , int age , double weight , string expectedType , int expectedAge , double expectedWeight)
        {

            // Arrange
            Animal actual;

            // Act
            actual = new Animal(type, age, weight);

            // Assert
            Assert.AreEqual(expectedType, actual.getAnimalType(), "Problem in Type");
            Assert.AreEqual(expectedAge, actual.getAge(), "Problem in Age");
            Assert.AreEqual(expectedWeight, actual.getWeight(), "Problem in Weight");


        }

        [DataTestMethod]
        [DataRow(new object[] { "Cat", 1, 2.5 },new object[] { "Cat", 1, 2.5 }, DisplayName = "Ctro1_ValidValues_ReturnsRelevantAnimal")]
        [DataRow(new object[] { "Cat", -1, 2.5 } ,new object[] { "Cat", 0, 2.5 }, DisplayName = "Ctro1_NegativeAge_ReturnsAnimalWithAge0")]
        [DataRow(new object[] { null, -11, -2.5 }, new object[] { "Lion", 0, 1 }, DisplayName = "Ctro1_IllegalValues_ReturnsDefaultAsExpected")]

        public void Ctro1_UsingObjects(object[] animalData , object[] expected)
        {

            // Arrange
            Animal actual;


            // Act
            actual = new Animal(Convert.ToString(animalData[0]),
                                Convert.ToInt32( animalData[1]) ,
                                Convert.ToDouble(animalData[2]));

            // Assert
            Assert.AreEqual(Convert.ToString(expected[0]), actual.getAnimalType(), "Problem in Type");
            Assert.AreEqual(Convert.ToInt32(expected[1]) , actual.getAge(), "Problem in Age");
            Assert.AreEqual(Convert.ToDouble(expected[2]), actual.getWeight(), "Problem in Weight");


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
            string type = null, expectedType = "Lion";
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


        [DataTestMethod]
        [DataRow("Cat", 5, 250, "Cat", 5, 250, DisplayName = "Ctro2_ValidValues_ReturnsRelevantAnimal")]
        [DataRow(null, 5, 250, "Lion", 5, 250, DisplayName = "Ctro2_AnimalIsNull_ReturnsAnimalAsLionWithDefaults")]

        public void Ctro2(string type, int age, double weight, string expectedType, int expectedAge, double expectedWeight)
        {

            // Arrange
            Animal actual;

            // Act
            actual = new Animal(type);

            // Assert
            Assert.AreEqual(expectedType, actual.getAnimalType(), "Problem in Type");
            Assert.AreEqual(expectedAge, actual.getAge(), "Problem in Age");
            Assert.AreEqual(expectedWeight, actual.getWeight(), "Problem in Weight");


        }

        [DataTestMethod]
        [DataRow(new object[] { "Cat" },new object[] { "Cat", 5, 250 }, DisplayName = "Ctro2_ValidValues_ReturnsRelevantAnimal")]
        [DataRow(new object[] { null }, new object[] { "Lion", 5, 250 }, DisplayName = "Ctro2_AnimalIsNull_ReturnsAnimalAsLionWithDefaults")]
        [DataRow(new object[] { "" }, new object[] { "Lion", 5, 250 }, DisplayName = "Ctro2_AnimalIsEmpty_ReturnsAnimalAsLionWithDefaults")]
        public void Ctro2_UsingObjects(object[] animalData, object[] expected)
        {

            // Arrange
            Animal actual;


            // Act
            actual = new Animal(Convert.ToString(animalData[0]));
                               

            // Assert
            Assert.AreEqual(Convert.ToString(expected[0]), actual.getAnimalType(), "Problem in Type");
            Assert.AreEqual(Convert.ToInt32(expected[1]), actual.getAge(), "Problem in Age");
            Assert.AreEqual(Convert.ToDouble(expected[2]), actual.getWeight(), "Problem in Weight");


        }




        [DataTestMethod]
        [DataRow(new object[] { "Cat", 1, 2.5 }, new object[] { "Cat", 1, 2.5 }, DisplayName = "Ctro1_ValidValues_ReturnsRelevantAnimal")]
        [DataRow(new object[] { "Cat", -1, 2.5 }, new object[] { "Cat", 0, 2.5 }, DisplayName = "Ctro1_NegativeAge_ReturnsAnimalWithAge0")]
        [DataRow(new object[] { null, -11, -2.5 }, new object[] { "Lion", 0, 1 }, DisplayName = "Ctro1_IllegalValues_ReturnsDefaultAsExpected")]
        [DataRow(new object[] { "Cat" }, new object[] { "Cat", 5, 250 }, DisplayName = "Ctro2_ValidValues_ReturnsRelevantAnimal")]
        [DataRow(new object[] { null }, new object[] { "Lion", 5, 250 }, DisplayName = "Ctro2_AnimalIsNull_ReturnsAnimalAsLionWithDefaults")]
        [DataRow(new object[] { "" }, new object[] { "Lion", 5, 250 }, DisplayName = "Ctro2_AnimalIsEmpty_ReturnsAnimalAsLionWithDefaults")]


        public void Ctros(object[] animalData, object[] expected)
        {

            // Arrange
            Animal actual;
            string type = Convert.ToString(animalData[0]);
            string expectedType = Convert.ToString(expected[0]);
            int expectedAge = Convert.ToInt32(expected[1]);
            double expectedWeight = Convert.ToDouble(expected[2]);


            // Act
            if (animalData.Length == 3)
                actual = new Animal(type,
                                    Convert.ToInt32(animalData[1]),
                                    Convert.ToDouble(animalData[2]));
            else
                actual = new Animal(type);


            // Assert
            Assert.AreEqual(expectedType, actual.getAnimalType(), "Problem in Type");
            Assert.AreEqual(expectedAge, actual.getAge(), "Problem in Age");
            Assert.AreEqual(expectedWeight, actual.getWeight(), "Problem in Weight");


        }
    }
}
