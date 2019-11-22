using System;

namespace Explicit_Interface
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            while (command != "End")
            {
                var personInfo = command.Split(" ");

                var name = personInfo[0];
                var country = personInfo[1];
                var age = int.Parse(personInfo[2]);

                IPerson personName = new Citizen(name, country, age);

                IResident personGenderAndName = new Citizen(name, country, age);

                Console.WriteLine(personName.GetName());
                Console.WriteLine(personGenderAndName.GetName());

                command = Console.ReadLine();
            }
        }
    }
}
