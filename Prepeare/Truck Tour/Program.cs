using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<Tuple<int, int, int>> pumps = new Queue<Tuple<int, int, int>>();  

            for (int i = 1; i <= n; i++)
            {
                int[] petrol = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            }
        }
    }
}
