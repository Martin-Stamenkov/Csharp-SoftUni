using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;

            for (int i = 0; i < number; i++)
            {
                double currentNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (min > currentNum)
                    {
                        min = currentNum;
                    }
                    else if (max < currentNum)
                    {
                        max = currentNum;
                    }
                }
                if (i % 2 == 1)
                {
                    max = currentNum;
                }

            }
        }
    }
}
