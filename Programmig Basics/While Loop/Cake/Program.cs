using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenth = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int countPiececOfCake = 0;
            int cakeSize = lenth * width;

            while (command != "STOP")
            {
                int PiecesOfCake = int.Parse(command);
                countPiececOfCake += PiecesOfCake;
                if (countPiececOfCake > cakeSize)
                {
                    int diffcakeSize = countPiececOfCake - cakeSize;
                    Console.WriteLine($"No more cake left! You need {diffcakeSize} pieces more.");
                    break;
                }

                command = Console.ReadLine();
                if (command == "STOP")
                {
                   
                    Console.WriteLine($"{cakeSize - countPiececOfCake} pieces are left.");
                    break;
                }
            }

        }
    }
}
