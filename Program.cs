using System;
using System.Linq;
using System.Collections.Generic;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int specialNumber = specialNumbers[0];
            int power = specialNumbers[1];

            while (numbers.Contains(specialNumber))
            {            
                for (int i = 0; i < power; i++)
                {
                    int index = numbers.IndexOf(specialNumber);
                    if (index - 1 >= 0)
                    {
                        numbers.RemoveAt(index - 1);
                    }
                }
                for (int i = 0; i < power; i++)
                {
                    int index = numbers.IndexOf(specialNumber);
                    if (index + 1 < numbers.Count)
                    {
                        numbers.RemoveAt(index + 1);
                    }
                }
                numbers.Remove(specialNumber);
            }
            Console.WriteLine(numbers.Sum());
           

        }
    }
}
