using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Animal
    {
        private string animalType;
        private int age;
        private double weight;

        // if the input animalType is null or empty string - Consider it as a "Lion"
        // if the input age is negative - Consider it as 0
        // if the input weight is not positive  - Consider it as 1

        public Animal(string animalType, int age, double weight)
        {
            this.animalType = string.IsNullOrEmpty(animalType) ? "Lion" : animalType;
            this.age = age < 0 ? 0 : age;
            this.weight = weight <= 0 ? 1 : weight;
        }

        // if the input animalType is null or empty string - Consider it as a "Lion"
        // default age = 5
        // default weight = 250KG
        public Animal(string animalType)
        {
            this.animalType = string.IsNullOrEmpty(animalType) ? "Lion" : animalType;
            this.age = 5;
            this.weight = 250;
        }

        #region Getters
        public string getAnimalType()
        {
            return animalType;
        }

        public int getAge()
        {
            return age;
        }

        public double getWeight()
        {
            return weight;
        }
        #endregion

        #region Setters
        public void setAnimalType(string animalType)
        {
            this.animalType = animalType;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        #endregion


        #region Methods

        // input : array of animals , string that represents the type of the animal 
        // output: number of animals of the same type
        public static int CountAnimalsByType(Animal[] animals, string aType)
        {
            if (animals == null || animals.Length == 0) return 0;

            int count = 0;
            for (int i = 0; i < animals.Length; i++)
                if (animals[i] != null && animals[i].animalType.Equals(aType))
                    count++;


            return count;
        }
        #endregion
    }
}
