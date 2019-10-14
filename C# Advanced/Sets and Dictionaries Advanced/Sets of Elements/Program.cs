using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengthSets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int lengthFirst = lengthSets[0];
            int lengthSecond = lengthSets[1];

            HashSet<int> firstSet = new HashSet<int>();

            for (int i = 0; i < lengthFirst; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < lengthSecond; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (firstSet.Contains(number))
                {
                    secondSet.Add(number);
                }
            }
            HashSet<int> uniqueEl = new HashSet<int>();

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    uniqueEl.Add(number);
                }
            }



            Console.WriteLine(string.Join(" ", uniqueEl));
            
        }
    }
}
