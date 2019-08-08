using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int numOfHolidaysForYear = int.Parse(Console.ReadLine());
            int WeekendsRetutnToHome = int.Parse(Console.ReadLine());

            int weekendsInOneYear = 48;

            int weekendsInSofia = weekendsInOneYear - WeekendsRetutnToHome;
            double saturdayGames = weekendsInSofia * 0.75;
            double holidayGamesinSofia = numOfHolidaysForYear * 0.66;
            double totalGames = saturdayGames + WeekendsRetutnToHome + holidayGamesinSofia;

            if (year == "leap")
            {
                double totalGamesinLeap = totalGames * 0.15;
                totalGames = totalGames + totalGamesinLeap;
                Console.WriteLine(Math.Floor(totalGames));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Floor(totalGames));
            }


        }
    }
}
