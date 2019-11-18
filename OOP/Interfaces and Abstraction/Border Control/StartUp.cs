using System;
using System.Collections.Generic;
using System.Linq;

namespace Border_Control
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Iidentifible> allEntities = new List<Iidentifible>(); 

            var command = Console.ReadLine();

            while (command != "End")
            {
                var lineInfo = command.Split(" ");

                if (lineInfo.Length == 2)
                {
                    var name = lineInfo[0];
                    var iD = lineInfo[1];

                    Iidentifible robot = new Robot(name, iD);
                    allEntities.Add(robot);
                }
                else if (lineInfo.Length == 3)
                {
                    var name = lineInfo[0];
                    var age = int.Parse(lineInfo[1]);
                    var iD = lineInfo[2];

                    Iidentifible citizen = new Citizen(name, age, iD);
                    allEntities.Add(citizen);
                }
                command = Console.ReadLine();
            }

            var fakeId = Console.ReadLine();

            foreach (var entity in allEntities)
            {
                if (entity.Id.EndsWith(fakeId))
                {
                    Console.WriteLine(entity.Id);
                }
            }

        }
    }
}
