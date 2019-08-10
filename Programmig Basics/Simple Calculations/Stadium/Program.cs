using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prihodi_na_stadion
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSectors = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double priceForTicket = double.Parse(Console.ReadLine());

            double Profit = stadiumCapacity * priceForTicket;
            double profitPerSector = Profit / countSectors;

            double charity = (Profit - (profitPerSector * 0.75)) / 8;
            Console.WriteLine($"Total income - {Profit:f2} BGN");
            Console.WriteLine($"Money for charity - {charity:f2} BGN");
        }
    }
}
