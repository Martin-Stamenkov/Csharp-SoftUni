using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Animals
{
    public abstract class Bird : Animal
    {
        private double wingSize;

        protected Bird(string animalType, string name, double weight, double wingSize) 
            : base(animalType, name, weight)
        {
            WingSize = wingSize;
        }

        public double WingSize
        {
            get { return wingSize; }
            set { wingSize = value; }
        }

        public override string ToString()
        {
            return $"{AnimalType} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }

    }
}
