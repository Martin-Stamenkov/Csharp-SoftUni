using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int total = 0;

            for (int i = 0; i < number; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                total += currentNum;
                if (currentNum > max)
                {
                    max=currentNum;
                }

            }
            int sumMinMax = total - max;
            if (sumMinMax == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = max - sumMinMax;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }

          
        }
    }
}
