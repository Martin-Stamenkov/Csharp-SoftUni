using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = num % 10;
            num = num / 10;
            int num2 = num % 10;
            int num3 = num / 10;

            for (int firstNum = 1; firstNum <=num1 ; firstNum++)
            {
                for (int secondNum = 1; secondNum <= num2; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <=num3; thirdNum++)
                    {
                        int total = firstNum * secondNum * thirdNum;
                        Console.WriteLine($"{firstNum} * {secondNum} * {thirdNum} = {total};");
                    }
                }
            }
        }
    }
}
