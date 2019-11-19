using System;
using System.Collections.Generic;
using System.Linq;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public abstract class Animal
    {
        private string name;
        private double weight;
        private int foodEaten;
        private string animaltype;

        protected Animal(string animalType ,string name, double weight)
        {
            AnimalType = animalType;
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string AnimalType
        {
            get { return animaltype; }
            set { animaltype = value; }
        }


        public int FoodEaten
        {
            get { return foodEaten; }
            set { foodEaten = value; }
        }

        public abstract void Eat(Food food);      
        
        public abstract double WeightMultiplayer { get; }

        public abstract void ProducingSound();
 
    }
}
