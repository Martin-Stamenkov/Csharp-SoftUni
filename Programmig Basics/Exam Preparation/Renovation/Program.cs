using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double shirochinaPod = double.Parse(Console.ReadLine());
            double duljinaPod = double.Parse(Console.ReadLine());
            double stranaNaTriygylnik = double.Parse(Console.ReadLine());
            double visochinaTriygylnik = double.Parse(Console.ReadLine());
            double cenaNaPlochka = double.Parse(Console.ReadLine());
            double sumaNaMaistora = double.Parse(Console.ReadLine());

            double ploshtNaPoda = shirochinaPod * duljinaPod;
            double ploshtNaPlochka = stranaNaTriygylnik * visochinaTriygylnik / 2;
            double neobodimiPlochki = ploshtNaPoda / ploshtNaPlochka;
            neobodimiPlochki = Math.Ceiling(neobodimiPlochki + 5);
            double total = neobodimiPlochki * cenaNaPlochka + sumaNaMaistora;
            if (budget >= total)
            {
                Console.WriteLine($"{budget - total:f2} lv left. ");
            }
            else if (budget<total)
            {
                Console.WriteLine($"You'll need {total-budget:f2} lv more.");
            }
        }
    }
}
