using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaklava = double.Parse(Console.ReadLine());
            double priceMuffins = double.Parse(Console.ReadLine());
            double kgShtolen = double.Parse(Console.ReadLine());
            double kgBonbons = double.Parse(Console.ReadLine());
            double kgBiscuits = double.Parse(Console.ReadLine());

            double priceShtolen = priceBaklava + (priceBaklava * 0.60);
            double sumShtolen = kgShtolen * priceShtolen;

            double priceBonbons = priceMuffins + (priceMuffins * 0.80);
            double sumBonbons = kgBonbons * priceBonbons;
            double sumBiscuits = kgBiscuits * 7.50;
            double total = sumBiscuits + sumBonbons + sumShtolen;

            Console.WriteLine($"{total:f2}");
        }
    }
}
