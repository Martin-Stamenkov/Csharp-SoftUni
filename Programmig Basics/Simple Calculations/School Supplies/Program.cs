using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPens = int.Parse(Console.ReadLine());
            int numMarkers = int.Parse(Console.ReadLine());
            double littersClean = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double pricePens = numPens * 5.80;
            double priceMarkers = numMarkers * 7.20;
            double priceLitters = littersClean * 1.20;
            double totalPrice = pricePens + priceMarkers + priceLitters;
            double priceAfterDiscount = totalPrice - ((totalPrice * percentDiscount) / 100);

            Console.WriteLine($"{priceAfterDiscount:f3}");
        }
    }
}
