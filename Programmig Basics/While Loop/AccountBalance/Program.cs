using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            double balance = 0.0;

            while (count < number)
            {
                double sum = double.Parse(Console.ReadLine());
                if (sum <= 0)
                {
                    Console.WriteLine("Invalid operation");
                    break;
                }
                balance = balance + sum;
                Console.WriteLine($"Increase: {sum:f2}");
                count++;
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
