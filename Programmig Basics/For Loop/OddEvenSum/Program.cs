using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= number; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else 
                {
                    oddSum += currentNum;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum} ");
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff} ");
            }
        }
    }
}
