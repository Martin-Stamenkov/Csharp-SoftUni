using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
       

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                double totalSaveMoney = 0;
                while (totalSaveMoney < minBudget)
                {
                    double saveMoneyForHoliday = int.Parse(Console.ReadLine());
                    totalSaveMoney += saveMoneyForHoliday;
                    
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
          
        }
    }
}
