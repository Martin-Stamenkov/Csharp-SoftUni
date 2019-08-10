using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weading_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int numOfRowsinFirstSector = int.Parse(Console.ReadLine());
            int numOfSeatsInOddRows = int.Parse(Console.ReadLine());
            int total = 0;

            for (char firstSector = 'A'; firstSector <= lastSector; firstSector++)
            {
                for (int numOfRows = 1; numOfRows <= numOfRowsinFirstSector; numOfRows++)
                {
                    if (numOfRows % 2 == 1)
                    {
                        for (int numseats = 1; numseats <= numOfSeatsInOddRows; numseats++)
                        {
                            Console.WriteLine($"{firstSector}{numOfRows}{(char)(numseats + 96)}");
                            total++;
                        }
                    }
                    else if (numOfRows % 2 == 0)
                    {
                        for (int numseats = 1; numseats <= numOfSeatsInOddRows + 2; numseats++)
                        {
                            Console.WriteLine($"{firstSector}{numOfRows}{(char)(numseats + 96)}");
                            total++;
                        }
                    }
                }
                numOfRowsinFirstSector++;
            }
            Console.WriteLine(total);
        }
    }
}
