using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] price = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();

            double[] vat = price.Select(x => x * 1.20).ToArray();

            foreach (var priceVat in vat)
            {
                Console.WriteLine($"{priceVat:f2}");
            }
        }
    }
}
