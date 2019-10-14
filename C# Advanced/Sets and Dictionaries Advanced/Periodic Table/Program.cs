using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueEl = new HashSet<string>(); 

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(" ");

                for (int j = 0; j < elements.Length; j++)
                {
                    if (!uniqueEl.Contains(elements[j]))
                    {
                        uniqueEl.Add(elements[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",uniqueEl.OrderBy(x=>x)));
        }
    }
}
