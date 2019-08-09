using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * lenght * height;
            int totalBoxCCM = 0;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int Boxes = int.Parse(command);
                totalBoxCCM += Boxes;
                if (freeSpace <= totalBoxCCM)
                {
                    Console.WriteLine($"No more free space! You need {totalBoxCCM - freeSpace} Cubic meters more.");
                    break;
                }

                command = Console.ReadLine();
            }
             if (command == "Done")
            {

                Console.WriteLine($"{freeSpace -= totalBoxCCM} Cubic meters left.");

            }

        }
    }
}
