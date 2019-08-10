using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyToBeSpend = double.Parse(Console.ReadLine());
            int numFantasticBook = int.Parse(Console.ReadLine());
            int numHorrorBook = int.Parse(Console.ReadLine());
            int numRomanticBook = int.Parse(Console.ReadLine());

            double sumAfterSell = (numFantasticBook * 14.90) + (numHorrorBook * 9.80) + (numRomanticBook * 4.30);
            double DDs = sumAfterSell * 0.20;
            double sumAfterDDs = sumAfterSell - DDs;

            if (sumAfterDDs > moneyToBeSpend)
            {
                double moneydiff = sumAfterDDs - moneyToBeSpend;
                double sumWin = Math.Floor(moneydiff * 0.10);
                moneydiff = moneydiff - sumWin;

                double total = moneyToBeSpend + moneydiff;
                Console.WriteLine($" {total:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {sumWin} leva.");
            }
            else 
            {
                double notEnoughMoney = moneyToBeSpend - sumAfterDDs;
                Console.WriteLine($"{notEnoughMoney:f2} money needed.");
            }

        }
    }
}
