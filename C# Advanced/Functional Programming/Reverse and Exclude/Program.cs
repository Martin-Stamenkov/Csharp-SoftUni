using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Reverse().Select(int.Parse).ToList();

            int divisible = int.Parse(Console.ReadLine());

            Predicate<int> func = x => x % divisible == 0;

             numbers.RemoveAll(func);

            Console.WriteLine(string.Join(" ",numbers));


        }
    }
}
