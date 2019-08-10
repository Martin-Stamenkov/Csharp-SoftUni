using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();
            int maxGoals = int.MinValue;
            string bestPlayer = string.Empty;
        
            while (namePlayer != "END")
            { 
                int goals = int.Parse(Console.ReadLine());
                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    if (maxGoals >= 10)
                    {
                        bestPlayer = namePlayer;
                        Console.WriteLine($"{bestPlayer} is the best player!");
                        Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
                        break;

                    }

                }

                namePlayer = Console.ReadLine();
            }

            if (maxGoals < 3)
            {
                bestPlayer = namePlayer;
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
            else if (maxGoals>=3)
            {
                bestPlayer = namePlayer;
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
           
        }
    }
}
