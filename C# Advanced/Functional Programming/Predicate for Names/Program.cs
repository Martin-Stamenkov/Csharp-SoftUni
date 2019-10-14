using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ").Where(x=>x.Length<=length).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine,names));
       }
    }
}
