using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public class Cat : Feline
    {

        private const double DefaultWeight = 0.30;

        public Cat(string animalType, string name, double weight, string livingRegion, string breed) 
            : base(animalType, name, weight,livingRegion, breed)
        {
           
        }

        public override double WeightMultiplayer => DefaultWeight;

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
            {
                Console.WriteLine($"{AnimalType} does not eat {food.GetType().Name}!");
                return;
            }
            FoodEaten += food.Quantity;
            Weight += WeightMultiplayer * food.Quantity;
        }

        public override void ProducingSound()
        {
            Console.WriteLine("Meow");
        }

       
    }
}
