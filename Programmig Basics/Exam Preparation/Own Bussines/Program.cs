using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own_Bussines
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirochina = int.Parse(Console.ReadLine());
            int duljina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int totalNumComp = 0;
            int totalFreeSpace = shirochina * duljina * visochina;
            while (command != "Done")
            {
                int numComputer = int.Parse(command);
                totalNumComp += numComputer;
                if (totalNumComp >= totalFreeSpace)
                {
                    Console.WriteLine($"No more free space! You need {totalNumComp - totalFreeSpace} Cubic meters more.");
                    break;
                }

                command = Console.ReadLine();
            }
            if (totalFreeSpace>totalNumComp)
            {
                Console.WriteLine($"{totalFreeSpace - totalNumComp} Cubic meters left.");
            }
           

        }
    }
}
