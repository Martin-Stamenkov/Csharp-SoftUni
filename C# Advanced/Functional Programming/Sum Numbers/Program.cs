using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ").Select(Parse).ToArray();
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());


        }

        private static int Parse(string str)
        {
            int n = 0;
            foreach (var ch in str)
            {
                n *= 10;
                n += ch - '0';
            }

            return n;
        }
    }
}