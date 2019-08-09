using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchBook = Console.ReadLine();
            int capacityLiballary = int.Parse(Console.ReadLine());
            int count = 0;

            while (count < capacityLiballary)
            {

                string nextBook = Console.ReadLine();
                if (nextBook == searchBook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                count++;

                if (count >= capacityLiballary)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {capacityLiballary} books.");

                }

            }
        }
    }
}
