using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    var animal = Console.ReadLine();

                    if (animal == "Beast!")
                    {
                        break;
                    }

                    var animaInfo = Console.ReadLine().Split(" ");

                    var name = animaInfo[0];
                    int age;
                    if (!int.TryParse(animaInfo[1], out age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                    var gender = animaInfo[2];

                    if (animal == "Cat")
                    {
                        Console.WriteLine(animal);
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(cat);
                        cat.ProduceSound();
                    }
                    else if (animal == "Dog")
                    {
                        Console.WriteLine(animal);
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine($"{dog}");
                        dog.ProduceSound();
                    }
                    else if (animal == "Frog")
                    {
                        Console.WriteLine(animal);
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(frog);
                        frog.ProduceSound();
                    }
                    else if (animal == "Kitten")
                    {
                        Console.WriteLine(animal);
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine($"{kitten}");
                        kitten.ProduceSound();
                    }
                    else if (animal == "Tomcat")
                    {
                        Console.WriteLine(animal);
                        Tomcat tomcat = new Tomcat(name, age);
                        Console.WriteLine($"{tomcat}");
                        tomcat.ProduceSound();
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
