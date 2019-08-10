using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscarWeeksInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string typeHall = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            double totalTikcketPrice = 0;

            if (movieName == "A Star Is Born")
            {
                if (typeHall == "normal")
                {
                    totalTikcketPrice += 7.50;
                }
                else if (typeHall == "luxury")
                {
                    totalTikcketPrice += 10.50;
                }
                else if (typeHall == "ultra luxury")
                {
                    totalTikcketPrice += 13.50;
                }
            }
            if (movieName == "Bohemian Rhapsody")
            {
                if (typeHall == "normal")
                {
                    totalTikcketPrice += 7.35;
                }
                else if (typeHall == "luxury")
                {
                    totalTikcketPrice += 9.45;
                }
                else if (typeHall == "ultra luxury")
                {
                    totalTikcketPrice += 12.75;
                }
            }
            if (movieName == "Green Book")
            {
                if (typeHall == "normal")
                {
                    totalTikcketPrice += 8.15;
                }
                else if (typeHall == "luxury")
                {
                    totalTikcketPrice += 10.25;
                }
                else if (typeHall == "ultra luxury")
                {
                    totalTikcketPrice += 13.25;
                }
            }
            if (movieName == "The Favourite")
            {
                if (typeHall == "normal")
                {
                    totalTikcketPrice += 8.75;
                }
                else if (typeHall == "luxury")
                {
                    totalTikcketPrice += 11.55;
                }
                else if (typeHall == "ultra luxury")
                {
                    totalTikcketPrice += 13.95;
                }
            }
            double inCome = totalTikcketPrice * numTickets;
            Console.WriteLine($"{movieName} -> {inCome:f2} lv.");
        }
    }
}
