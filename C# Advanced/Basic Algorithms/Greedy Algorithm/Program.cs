using System;

namespace Greedy_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = { 100, 50, 50, 100, 20, 50, 20, 100, 10, 10 };

            int targetSum = 180;
            int currentSum = 0;

            Array.Sort(array);
            Array.Reverse(array);

            int count = 0;

            while (currentSum < targetSum)
            {
                if (currentSum + array[count] <= targetSum)
                {
                    currentSum += array[count];
                }
                    count++;
            }
            if (currentSum == targetSum)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }

        }
    }
}
