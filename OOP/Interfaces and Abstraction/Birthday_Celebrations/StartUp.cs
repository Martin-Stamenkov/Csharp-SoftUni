using System;
using System.Collections.Generic;

namespace Birthday_Celebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> petsAndHumans = new List<IBirthable>();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var inputLine = command.Split(" ");

                var entity = inputLine[0];

                if (entity == "Citizen")
                {
                    var name = inputLine[1];
                    var age = int.Parse(inputLine[2]);
                    var iD = inputLine[3];
                    var birthday = inputLine[4];

                    petsAndHumans.Add(new Citizen(name, age, iD, birthday));

                }
                else if (entity == "Robot")
                {
                    command = Console.ReadLine();
                    continue;
                }
                else if (entity == "Pet")
                {
                    var name = inputLine[1];
                    var birthday = inputLine[2];

                    petsAndHumans.Add(new Pet(name, birthday));
                }

                command = Console.ReadLine();
            }
            var yearOfBirthday = Console.ReadLine();

            foreach (var entity in petsAndHumans)
            {
                if (entity.Birthdate.EndsWith(yearOfBirthday))
                {
                    Console.WriteLine(entity.Birthdate);
                }
            }
        }
    }
}
