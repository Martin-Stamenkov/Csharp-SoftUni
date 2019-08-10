using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentHall = double.Parse(Console.ReadLine());
            double oscarPrice = rentHall - (rentHall * 0.30);
            double cateringPrice = oscarPrice - (oscarPrice * 0.15);
            double soundSystemPrice = cateringPrice / 2;
            double total = oscarPrice + cateringPrice + soundSystemPrice + rentHall;
            Console.WriteLine($"{total:f2}");
        }
    }
}
