using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<int> uniqueEl = new HashSet<int>();
            HashSet<int> eachNum = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!eachNum.Contains(number))
                {
                   eachNum.Add(number);
                }
                else
                {
                    uniqueEl.Add(number);

                }

            }
            Console.WriteLine(string.Join(" ",uniqueEl));
        }
    }
}
