using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Shortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<IBuyer> all = new HashSet<IBuyer>();
            
            var countPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPeople; i++)
            {
                var peopleInfo = Console.ReadLine().Split(" ");
                var name = peopleInfo[0];
                var age = int.Parse(peopleInfo[1]);

                if (peopleInfo.Length == 4)
                {
                    
                    var iD = peopleInfo[2];
                    var birthday = peopleInfo[3];

                    all.Add(new Citizen(name, age, iD, birthday));
                }
                else if (peopleInfo.Length == 3)
                {                   
                    var group = peopleInfo[2];

                    all.Add(new Rebel(name, age, group));
                }
            }

            var names = Console.ReadLine();

            while (names != "End")
            {
                foreach (var entity in all)
                {
                    if (entity.Name == names)
                    {
                        entity.BuyFood();
                    }
                }

                names = Console.ReadLine();
            }
            Console.WriteLine(all.Sum(x=>x.Food));
        }
    }
}
