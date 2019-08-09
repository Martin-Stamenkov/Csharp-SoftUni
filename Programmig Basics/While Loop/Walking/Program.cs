using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalsteps = 0;
            while (totalsteps < 10000)
            {
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                    totalsteps += int.Parse(Console.ReadLine());
                    if (totalsteps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    else if (totalsteps < 10000)
                    {
                        Console.WriteLine($"{10000 - totalsteps} more steps to reach goal.");
                        break;
                    }
                }
                totalsteps += int.Parse(command);
                if (totalsteps>=10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
            }
        }
    }
}
