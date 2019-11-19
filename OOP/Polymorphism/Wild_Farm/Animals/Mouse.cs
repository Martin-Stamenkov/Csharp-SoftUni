using System;
using System.Collections.Generic;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Mouse : Mammal
    {
        private const double DefaultWeight = 0.10;

        public Mouse(string animalType, string name, double weight, string livingRegion)
            : base(animalType,name, weight, livingRegion)
        {
           
               
        }

        public override double WeightMultiplayer => DefaultWeight;

        public override void Eat(Food food)
        {
            
                if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
                {
                    Console.WriteLine($"{AnimalType} does not eat {food.GetType().Name}!");
                    return;
                }
                FoodEaten += food.Quantity;
                Weight += WeightMultiplayer * food.Quantity;
            
        }

        public override void ProducingSound()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return $"{AnimalType} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
