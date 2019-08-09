using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
         
            int count = 1;
            double sum = 0;
            double avargeGrade = 0;

            while (count <= 12)
            {
                double yearsGrades = double.Parse(Console.ReadLine());
                if (yearsGrades >= 4)
                {
                    sum += yearsGrades;
                    count++;
                }
                
            }
            avargeGrade = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {avargeGrade:f2}");
        }
    }
}
