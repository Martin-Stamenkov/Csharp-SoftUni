using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int countDays =1;
            int BaseLagerAndReached = 5364;
            int Everest = 8848;

            while (countDays < 5 && command != "END" )
            {
                
                int reachedMetters = int.Parse(Console.ReadLine());
                if (command == "Yes")
                {
                    countDays++;
                }
                BaseLagerAndReached += reachedMetters;

                if (BaseLagerAndReached >= Everest)
                {
                    Console.WriteLine($"Goal reached for {countDays} days!");
                    break;
                }
                
               
                command = Console.ReadLine();
                
            }

            if (BaseLagerAndReached < Everest)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(BaseLagerAndReached);
            }
            



        }
    }
}
