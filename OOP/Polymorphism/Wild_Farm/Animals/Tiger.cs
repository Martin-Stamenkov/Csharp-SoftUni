using System;
using System.Collections.Generic;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Tiger : Feline
    {
        private const double DefaultWeight = 1;

        public Tiger(string animalType,string name, double weight, string livingRegion, string breed)
            : base(animalType, name, weight, livingRegion, breed)
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
            Console.WriteLine("ROAR!!!");
        }
    }
}
