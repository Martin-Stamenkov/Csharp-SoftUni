using System;
using System.Collections.Generic;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Dog : Mammal
    {
        private const double DefaultWeight = 0.40;

        public Dog(string animalType, string name, double weight,string livingRegion) 
            : base(animalType, name, weight, livingRegion)
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
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return $"{AnimalType} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
