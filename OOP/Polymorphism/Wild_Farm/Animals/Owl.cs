using System;
using System.Collections.Generic;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Owl : Bird
    {
        private const double DefaultWeight = 0.25;

        public Owl(string animalType, string name, double weight, double wingSize) 
            : base(animalType, name, weight, wingSize)
        {
          
        }

        public override double WeightMultiplayer => DefaultWeight;

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                Console.WriteLine($"{AnimalType} does not eat {food.GetType().Name}!");
                return;
            }
            FoodEaten += food.Quantity;
            Weight += WeightMultiplayer * food.Quantity;
        }

        public override void ProducingSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
