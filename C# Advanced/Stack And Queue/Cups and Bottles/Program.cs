using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] cupsCapacity = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] filledBottles = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queueCups = new Queue<int>(cupsCapacity);
            Stack<int> stackBottles= new Stack<int>(filledBottles);

            int wastedWater = 0;

            while (queueCups.Any())
            {
                int currentCup = queueCups.Peek();
                int currentBottle = stackBottles.Peek();

                if (currentCup <= currentBottle)
                {
                    wastedWater += (currentBottle - currentCup);
                    queueCups.Dequeue();
                    stackBottles.Pop();
                }
                else if (currentCup>=currentBottle)
                {
                    currentCup -= currentBottle;
                    stackBottles.Pop();
                    while (currentCup > 0)
                    {
                        if (stackBottles.Any())
                        {
                            int nextBottle = stackBottles.Peek();
                            currentCup -= nextBottle;
                            if (nextBottle > currentCup)
                            {
                                wastedWater += nextBottle - (currentCup + nextBottle);
                                queueCups.Dequeue();
                                stackBottles.Pop();
                            }
                            else if (nextBottle <= currentCup)
                            {
                                stackBottles.Pop();
                            }
                        }
                        else
                        {
                            break;
                        }
                    }                                          
                }
                if (stackBottles.Count == 0)
                {
                    Console.WriteLine($"Cups: "+ string.Join(" ",queueCups));
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    return;
                }                

            }
            Console.WriteLine($"Bottles: " + string.Join(" ",stackBottles));
            Console.WriteLine($"Wasted litters of water: {wastedWater}");


        }
    }
}
