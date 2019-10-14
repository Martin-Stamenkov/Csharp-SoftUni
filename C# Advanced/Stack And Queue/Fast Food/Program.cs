using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var queue = new Queue<int>(orders);

            int sum = 0;

            Console.WriteLine(queue.Max());

            while (queue.Any())
            {
                    quantityFood -= queue.Dequeue();
     
                if (sum<=quantityFood)
                {
                sum += queue.Peek();

                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    return;

                }

            }
                    Console.WriteLine("Orders complete");

        }
    }
}