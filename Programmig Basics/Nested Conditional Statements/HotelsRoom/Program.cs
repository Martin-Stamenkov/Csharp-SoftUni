using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartamentPrice = 0;

            if (months == "May" || months == "October")
            {
                studioPrice = 50;
                apartamentPrice = 65;
                if (numNights > 14 && numNights>7)
                {
                    studioPrice = studioPrice - studioPrice * 0.30;
                }
                else if (numNights > 7 && numNights<14) 
                {
                    studioPrice = studioPrice - studioPrice * 0.05;
                }

            }
            else if (months == "June" || months == "September")
            {
                studioPrice = 75.20;
                apartamentPrice = 68.70;
                if (numNights > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.20;
                }
            }
            else if (months == "July" || months == "August")
            {
                studioPrice = 76;
                apartamentPrice = 77;
            }
            if (numNights > 14)
            {
                apartamentPrice -= apartamentPrice * 0.10;
            }
            Console.WriteLine($"Apartment: {apartamentPrice*numNights:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice*numNights:f2} lv.");
        }
    }
}
