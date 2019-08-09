using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0.0;
            int count = 1;
            int excuted = 0;
            bool gruated = false;

            while (count <= 12)
            {
                double yearsGrades = double.Parse(Console.ReadLine());
                if (yearsGrades >= 4)
                {
                    sum += yearsGrades;
                    count++;
                }

                else if (yearsGrades < 4)
                {
                    excuted++;

                }
                if (excuted >= 2)
                {
                    gruated = true;
                    break;
                }
            }

            double avarge = 0;
            avarge = sum / 12;
            if (gruated == false)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avarge:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {count} grade");
                
            }
        }
       
        
    }
}
