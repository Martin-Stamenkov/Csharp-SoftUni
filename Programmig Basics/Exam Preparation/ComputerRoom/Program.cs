using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numHours = int.Parse(Console.ReadLine());
            int numPeople = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double Price = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (dayTime == "day")
                {
                    Price += 10.50;
                }
                else if (dayTime == "night")
                {
                    Price += 8.40;
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (dayTime == "day")
                {
                    Price += 12.60;
                }
                else if (dayTime == "night")
                {
                    Price += 10.20;
                }
            }
            if (numPeople >= 4)
            {
                Price -= (Price * 0.1);
            }
            if (numHours >= 5)
            {
                Price -= (Price * 0.50);
            }
            double total = (numPeople * Price) * numHours;
            Console.WriteLine($"Price per person for one hour: {Price:f2}");
            Console.WriteLine($"Total cost of the visit: {total:f2}");
        }
    }
    
}
