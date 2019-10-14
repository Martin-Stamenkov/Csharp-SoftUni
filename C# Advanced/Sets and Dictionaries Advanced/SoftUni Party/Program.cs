using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string reservationNumbers = Console.ReadLine();

            HashSet<string> guests = new HashSet<string>();
   

            while (reservationNumbers!="PARTY")
            {
                guests.Add(reservationNumbers);

                reservationNumbers = Console.ReadLine();
                
            }
            string command = Console.ReadLine();
            while (command != "END") 
            {
                guests.Remove(command);

                command = Console.ReadLine();
            }
            Console.WriteLine(guests.Count());

            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            foreach (var number in guests)
            {
                if (char.IsDigit(number[0]))
                {
                    vip.Add(number);
                }
                else
                {
                    regular.Add(number);
                }
            }
            foreach (var number in vip)
            {
                Console.WriteLine(number);
            }

            foreach (var number in regular)
            {
                Console.WriteLine(number);
            }
           
        }
    }
}
