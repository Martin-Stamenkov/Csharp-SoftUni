using System;
using System.Linq;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            HashSet<string> cars = new HashSet<string>();

            while (command!="END")
            {
                string[] tokens = command.Split(", ");

                string direction = tokens[0];
                string carNumber = tokens[1];

                if (direction.StartsWith("IN"))
                {
                    cars.Add(carNumber);
                }
                else if (direction.StartsWith("OUT"))
                {
                    cars.Remove(carNumber);
                }


                command = Console.ReadLine();                  
            }

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
