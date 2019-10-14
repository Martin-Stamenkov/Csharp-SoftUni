using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minFunc = numbers =>
            {
                int minValue = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                return minValue;
            };
 
            int[] inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int  result = minFunc(inputNumbers);

            Console.WriteLine(result);
            


        }
    }
}
