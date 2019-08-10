using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prize
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectSteps = int.Parse(Console.ReadLine());
            double prizeForOnePoint = double.Parse(Console.ReadLine());
            int totalPoints = 0;

            for (int i = 1; i <= projectSteps; i++)
            {
                int points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    totalPoints += (points * 2);
                }
                else
                {
                    totalPoints += points;
                }
            }
            double totalPrize = prizeForOnePoint * totalPoints;
            Console.WriteLine($"The project prize was {totalPrize:f2} lv.");
        }
    }
}
