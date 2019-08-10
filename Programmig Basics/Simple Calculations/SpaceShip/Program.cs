using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double spaceshipWidth = double.Parse(Console.ReadLine());
            double spaceshipLenght = double.Parse(Console.ReadLine());
            double spaceshipHeight = double.Parse(Console.ReadLine());
            double austronautsHeight = double.Parse(Console.ReadLine());

            double volumeSpaceship = spaceshipWidth * spaceshipLenght * spaceshipHeight;
            double roomVolume = (austronautsHeight + 0.40) * 2 * 2;
            double freeSpace = Math.Floor(volumeSpaceship / roomVolume);

            if (freeSpace < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (freeSpace <= 10)
            {
                Console.WriteLine($"The spacecraft holds {freeSpace} astronauts.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}
