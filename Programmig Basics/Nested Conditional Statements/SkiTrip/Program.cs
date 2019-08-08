using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInHotel = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string gradeOfHotel = Console.ReadLine();

            int nightsInHotel = daysInHotel - 1;
            double discount = 0.0;
            double roomPrice = 0.0;

            if (typeRoom == "apartment")
            {
                roomPrice = 25;
                if (daysInHotel <= 10)
                {
                    discount = 0.30;
                }
                else if (daysInHotel >= 10 && daysInHotel <= 15)
                {
                    discount = 0.35;
                }
                else if (nightsInHotel > 15)
                {
                    discount = 0.50;

                }
            }
            else if (typeRoom == "president apartment")
            {
                roomPrice = 35;
                if (daysInHotel <= 10)
                {
                    discount = 0.10;
                }
                else if (daysInHotel >= 10 && daysInHotel <= 15)
                {
                    discount = 0.15;
                }
                else if (daysInHotel > 15)
                {
                    discount = 0.20;
                }
            }
            else if (typeRoom == "room  for one person")
            {
                roomPrice = 18;
            }

            double totalPrice = roomPrice * nightsInHotel;
            totalPrice -= totalPrice * discount;

            if (gradeOfHotel == "positive")
            {
                totalPrice = totalPrice + totalPrice * 0.25;
            }
            else if (gradeOfHotel == "negative")
            {
                if (daysInHotel > 1 && daysInHotel < 10)
                {
                    totalPrice = totalPrice - totalPrice * discount;
                }
            }

            Console.WriteLine("{0:f2}",totalPrice);
        }
    }
}
