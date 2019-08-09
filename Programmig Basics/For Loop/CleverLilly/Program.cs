using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLilly = int.Parse(Console.ReadLine());
            double washMashine = double.Parse(Console.ReadLine());
            int priceTools = int.Parse(Console.ReadLine());
            int sumEvenBirthDays = 0;
            double sumTools = 0;

            for (int i = 1; i <= ageLilly; i++)
            {
                if (i % 2 == 0)
                {
                    sumEvenBirthDays += 10;
                    sumEvenBirthDays -= 1;
                }
                if (i % 2 == 1)
                {
                    sumTools += priceTools;
                }
            }
            double totalSum = sumEvenBirthDays + sumTools;
            if (totalSum>washMashine)
            {
                totalSum -= washMashine;
                Console.WriteLine($"Yes! {totalSum:f2}" );
            }

        }
    }
}
