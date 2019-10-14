using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceEachBullet = int.Parse(Console.ReadLine());
            int sizeOftheGunBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int valueIntell = int.Parse(Console.ReadLine());

            Stack<int> stackBullets = new Stack<int>(bullets);
            Queue<int> queueLocks = new Queue<int>(locks);

            int countSize = 0;
            int eachBullet = 0;

            while (queueLocks.Any())
            {
                if (stackBullets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
                    return;
                }
                int currentBullet = stackBullets.Peek();
                int currentLock = queueLocks.Peek();

                if (currentBullet<=currentLock)
                {
                    Console.WriteLine("Bang!");
                    stackBullets.Pop();
                    eachBullet++;
                    queueLocks.Dequeue();
                    countSize++;
                    if (stackBullets.Count==0)
                    {
                        continue;
                    }
                    if (countSize == sizeOftheGunBarrel)                      
                    {
                        Console.WriteLine("Reloading!");
                        countSize = 0;
                    }
                }
                else
                {
                    Console.WriteLine("Ping!");
                    stackBullets.Pop();
                    eachBullet++;
                    countSize++;
                    if (stackBullets.Count == 0)
                    {
                        continue;
                    }
                    if (countSize == sizeOftheGunBarrel)
                    {
                        Console.WriteLine("Reloading!");
                        countSize = 0;
                    }
                }
                
            }

            int bulleitCost = eachBullet * priceEachBullet;
            int total = valueIntell - bulleitCost;
            Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${total}");
        }
    }
}
