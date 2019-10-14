using System;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split(" ");

                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                
                Person person = new Person(name, age);

                family.AddPeople(person);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");


        }
    }
}

