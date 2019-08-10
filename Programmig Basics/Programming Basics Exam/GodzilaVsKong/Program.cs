using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetMovie = double.Parse(Console.ReadLine());
            int numStatists = int.Parse(Console.ReadLine());
            double priceClothesPerOneStatist = double.Parse(Console.ReadLine());
            double priceDecoration = budgetMovie * 0.10;
            double priceClothes = numStatists * priceClothesPerOneStatist;
            if (numStatists > 150)
            {
                priceClothes -= priceClothes * 0.10;
            }
            double totalSum = priceDecoration + priceClothes;
            if (totalSum <= budgetMovie)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budgetMovie - totalSum:f2} leva left.");
            }
            else if (budgetMovie<totalSum)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum-budgetMovie:f2} leva more.");
            }
        }
    }
}
