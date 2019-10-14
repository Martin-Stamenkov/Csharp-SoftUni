using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            Predicate<int> odd = x =>  x % 2 != 0;
            Predicate<int> even = x =>  x % 2 == 0;

            List<int> output = new List<int>();
            List<int> list = new List<int>();

            for (int currNum = numbers[0]; currNum <= numbers[1] ; currNum++)
            {
                list.Add(currNum);
            }

            if (command == "odd")
            {
                output = list.FindAll(odd);
            }
            else if (command == "even")
            {
                output = list.FindAll(even);
            }

            Console.WriteLine(string.Join(" ",output));

        }
    }
}
