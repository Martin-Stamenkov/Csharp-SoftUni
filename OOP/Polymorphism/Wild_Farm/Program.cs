using System;
using System.Collections.Generic;
using Wild_Farm.Animals;
using Wild_Farm.Foods;

namespace Wild_Farm
{
    public class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            List<Animal> animals = new List<Animal>();

            while (command != "End")
            {
                var animalInfo = command
                    .Split(" ");

                Animal animal = SetAnimals(animals, animalInfo);

                animals.Add(animal);
                animal.ProducingSound();

                var foodInfo = Console.ReadLine()
                    .Split(" ");

               Food food =  SetFood(foodInfo);
                animal.Eat(food);

                command = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food SetFood(string[] foodInfo)
        {
            if (foodInfo[0] == "Vegetable")
            {
               return new Vegetable(foodInfo[0], int.Parse(foodInfo[1]));
            }
            else if (foodInfo[0] == "Fruit")
            {
                return new Fruit(foodInfo[0], int.Parse(foodInfo[1]));
            }
            else if (foodInfo[0] == "Meat")
            {
                return new Meat(foodInfo[0], int.Parse(foodInfo[1]));
            }
            else if (foodInfo[0] == "Seeds")
            {
                return new Seeds(foodInfo[0], int.Parse(foodInfo[1]));
            }
            return null;
        }

        private static Animal SetAnimals(List<Animal> animals, string[] animalInfo)
        {
            if (animalInfo[0] == "Cat")
            {
                 return new Cat(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
            }
            else if (animalInfo[0] == "Tiger")
            {
                return new Tiger(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
            }
            else if (animalInfo[0] == "Dog")
            {
                return new Dog(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
            }
            else if (animalInfo[0] == "Mouse")
            {
                return new Mouse(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
            }
            else if (animalInfo[0] == "Owl")
            {
                return new Owl(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
            }
            else if (animalInfo[0] == "Hen")
            {
               return new Hen(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
            }
            return null;
        }
    }
}
