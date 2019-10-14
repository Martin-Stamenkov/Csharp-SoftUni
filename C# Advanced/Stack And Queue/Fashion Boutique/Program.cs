using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int capacity = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(clothes);

            int eachRack = 0;
            int currentCapacity = 0;

            while (stack.Any())
            {
                currentCapacity += stack.Peek();

                if (currentCapacity<capacity)
                {
                    if (stack.Count==1)
                    {
                        eachRack++;
                    }
                    stack.Pop();
  
                }

                else if (currentCapacity == capacity)
                {
                    if (stack.Any())
                    {

                    stack.Pop();
                    eachRack++;
                    currentCapacity = 0;
                    }
                }
                else
                {
     
                    eachRack++;
                    currentCapacity = 0;
                    
                }
            }
            Console.WriteLine(eachRack);
        }
    }
}
