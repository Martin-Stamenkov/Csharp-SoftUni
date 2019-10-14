using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> action = name => names.ToList().ForEach(x => Console.WriteLine($"Sir {x}"));

            action(names);


        }
    }
}
