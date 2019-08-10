using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int computers = int.Parse(Console.ReadLine());
            double sales = 0;
            double sumRating = 0;

            for (int i = 0; i < computers; i++)
            {
                int r = int.Parse(Console.ReadLine());
                int rating = r % 10;
                double possibleSales = r / 10;
                sumRating += rating;

                if (rating == 2)
                {
                    sales += 0;
                }
                else if (rating == 3)
                {
                    sales += possibleSales * 0.5;
                }
                else if (rating == 4)
                {
                    sales += possibleSales * 0.7;
                }
                else if (rating == 5)
                {
                    sales += possibleSales * 0.85;
                }
                else if (rating == 6)
                {
                    sales += possibleSales;
                }
            }

            double avgRating = sumRating / computers;

            Console.WriteLine($"{sales:f2}");
            Console.WriteLine($"{avgRating:f2}");

        }
    }
}
        