using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxNumber = int.Parse(Console.ReadLine());
            var divideNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var numbersToRange = new List<int>();

            for (int i = 1; i <= maxNumber; i++)
            {
                numbersToRange.Add(i);
            }


            // Predicate<int> divide = x => x % number == 0;

            Func<int, int[],bool> divide = (num,numbers) =>
            {
                bool isDivisible = true;

                foreach (var number in numbers)
                {
                    if (num % number !=0)
                    {
                        isDivisible = false;
                    }
                }
                return isDivisible;
            };

            numbersToRange = numbersToRange.Where(x => divide(x, divideNumbers)).ToList();


            Console.WriteLine(string.Join(" ",numbersToRange));
            
        }
    }
}
