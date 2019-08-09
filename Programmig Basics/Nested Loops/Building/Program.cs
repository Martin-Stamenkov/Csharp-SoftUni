using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFloor = int.Parse(Console.ReadLine());
            int numRoomsPerFloor = int.Parse(Console.ReadLine());
            for (int i = numFloor; i >= 1; i--)
            {
                for (int countRoom = 0; numRoomsPerFloor > countRoom; countRoom++)
                {
                    if (i == numFloor)
                    {
                        Console.Write($"L{i}{countRoom} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{countRoom} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{countRoom} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
