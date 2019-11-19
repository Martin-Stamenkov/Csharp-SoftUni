using System;
using System.Collections.Generic;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Hen : Bird
    {
        private const double DefaultWeight = 0.35;

        public Hen(string animalType, string name, double weight, double wingSize)
            : base(animalType, name, weight, wingSize)
        {

        }

        public override double WeightMultiplayer => DefaultWeight;

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;
            Weight += WeightMultiplayer * food.Quantity;
        }

        public override void ProducingSound()
        {
            Console.WriteLine("Cluck");
        }
    
    }
}
