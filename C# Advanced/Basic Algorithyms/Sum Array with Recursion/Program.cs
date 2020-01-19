using System;

namespace Sum_Array_with_Recursion
{
    public class Program
    {
        private static int SumArray(int[] myArray, int index)
        {
            if (index == myArray.Length)
            {
                return 0;
            }
            return myArray[index] + SumArray(myArray, index + 1);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            int index = 0;

            int result = SumArray(myArray, index);

            Console.WriteLine(result);
        }
    }
}
