using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int student = 0;
            int standart = 0;
            int kid = 0;
            double peopleInHall = 0;

            while (movieName != "Finish")
            {
                int freeSpace = int.Parse(Console.ReadLine());
                for (int i = 1; i <= freeSpace; i++)
                {
                    string type = Console.ReadLine();
                    if (type == "End")
                    {
                        break;
                    }
                    else
                    {
                        if (type == "student")
                        {
                            student++;
                        }
                        else if (type == "standard")
                        {
                            standart++;
                        }
                        else if (type == "kid")
                        {
                            kid++;
                        }
                    }
                    peopleInHall = i;
                }
                Console.WriteLine($"{movieName} - {peopleInHall / freeSpace * 100:f2}% full.");

                movieName = Console.ReadLine();
            }
            int totalTickets = student + standart + kid;
            double studentPercentage = student*1.00/ totalTickets * 100;
            double standartPercentage = standart*1.00/ totalTickets * 100;
            double kidPercentage = kid * 1.00 / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPercentage:f2}% student tickets.");
            Console.WriteLine($"{standartPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidPercentage:f2}% kids tickets.");

        }
    }
}