using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            double numMovie = double.Parse(Console.ReadLine());
            double avarageRaiting = 0;
            double minRaiting = double.MaxValue;
            double maxRaiting = double.MinValue;
            string nameHight = string.Empty;
            string nameLow = string.Empty;
            for (int i = 1; i <= numMovie; i++)

            {
                string nameMovie = Console.ReadLine();
                double raiting = double.Parse(Console.ReadLine());
                if (raiting > maxRaiting)
                {
                    maxRaiting = raiting;
                    nameHight = nameMovie;
                }
                else if (raiting < minRaiting)
                {
                    minRaiting = raiting;
                    nameLow = nameMovie;
                }
                avarageRaiting += raiting;
            }
            double totalAvarageRaiting = avarageRaiting / numMovie;
            Console.WriteLine($"{nameHight} is with highest rating: {maxRaiting:f1}");
            Console.WriteLine($"{nameLow} is with lowest rating: {minRaiting:f1}");
            Console.WriteLine($"Average rating: {totalAvarageRaiting:f1}");
        }
    }
}
