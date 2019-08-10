using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceVaucher = int.Parse(Console.ReadLine());
            string command = (Console.ReadLine());
            int lenght = command.Length;
            int ticketPrice = 0;
            int ticket = 0;
            int others = 0;

            while (command != "End")
            {

                if (command.Length > 8)
                {
                    ticketPrice = command[0] + command[1];
                    
                }
                else
                {
                    ticketPrice = command[0];
                    
                }
                priceVaucher -= ticketPrice;
                if (priceVaucher < 0)
                {
                    break;
                }
                if (command.Length > 8)
                {
                    ticket++;
                }
                else
                {
                    others++;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(ticket);
            Console.WriteLine(others);
        }
    }
}
