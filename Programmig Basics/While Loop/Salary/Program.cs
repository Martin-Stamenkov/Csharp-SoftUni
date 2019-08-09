using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOpenTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOpenTabs; i++)
            {
                string nameWeb = Console.ReadLine();
                if (nameWeb == "Facebook")
                {
                    salary -= 150;
                }
                else if (nameWeb == "Instagram")
                {
                    salary -= 100;
                }
                else if (nameWeb == "Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);

            }
            
            
        }
    }
}
