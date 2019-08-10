using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letters_combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char finalLetter = char.Parse(Console.ReadLine());
            char letterToMiss = char.Parse(Console.ReadLine());
            int count = 0;

            for (char firstComb = firstLetter; firstComb <= finalLetter; firstComb++)
            {
                for (char secondComb = firstLetter; secondComb <= finalLetter; secondComb++)
                {
                    for (char thirdComb = firstLetter; thirdComb <= finalLetter; thirdComb++)
                    {
                        if (letterToMiss != firstComb && letterToMiss != secondComb && letterToMiss != thirdComb)
                        {
                            Console.Write($"{firstComb}{secondComb}{thirdComb} ");
                            count++;

                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
