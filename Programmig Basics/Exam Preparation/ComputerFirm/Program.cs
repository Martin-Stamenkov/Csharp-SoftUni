using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numComp = int.Parse(Console.ReadLine());
            double avarageReiting = 0;
            double totalPosiblesSales = 0;


            for (int i = 0; i < numComp; i++)
            {
               
                int numSalesAndReiting = int.Parse(Console.ReadLine());
                int reiting = numSalesAndReiting % 10;
                double posiblesSales = numSalesAndReiting / 10;
                avarageReiting += reiting;
                if (reiting == 3) totalPosiblesSales += posiblesSales * 0.5;
                else if (reiting == 4) totalPosiblesSales += posiblesSales * 0.7;
                else if (reiting == 5) totalPosiblesSales += posiblesSales * 0.85;
                else if (reiting == 6) totalPosiblesSales += posiblesSales;
                else if (reiting == 2) totalPosiblesSales += 0; 

            }

            Console.WriteLine($"{totalPosiblesSales:f2}");
            Console.WriteLine($"{avarageReiting/numComp:f2}");
            
        }
    }
}
