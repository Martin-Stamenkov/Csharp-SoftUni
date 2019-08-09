using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumtotal1 = 0;
            int sumtotal2 = 0;

            for (int i = 1; i <= number; i++)
            {
                int current = int.Parse(Console.ReadLine());
                sumtotal1 += current;
            }
            for (int a = 1; a <= number; a++)
            {
                int current = int.Parse(Console.ReadLine());
                sumtotal2 += current;
            }
            if (sumtotal1 == sumtotal2)
            {
                Console.WriteLine($"Yes sum = {sumtotal1}");
            }
            else
            {
                int diff = sumtotal1 - sumtotal2;
                Console.WriteLine($"No, diff = {Math.Abs(sumtotal1-sumtotal2)}");

            }
        }
    }
}
