using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var listPerson = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var personInfo = Console.ReadLine().Split(" ");
                var firstName = personInfo[0];
                var lastName = personInfo[1];
                var age = int.Parse(personInfo[2]);

                Person person = new Person(firstName, lastName, age);
                listPerson.Add(person);
            }

            foreach (var person in listPerson.OrderBy(n => n.FirstName).ThenBy(a => a.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
}
