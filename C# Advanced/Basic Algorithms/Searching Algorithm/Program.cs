using System;

namespace Searching_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            const int searchingNum = 18;

            int[] array = new int[100];          

            for (int i = 0; i < 100; i++)
            {
                array[i] = i;
            }

            Console.WriteLine(string.Join(" ",array));

            Console.WriteLine(BinarySearch(array, 0, array.Length, searchingNum));               
        }

        private static int BinarySearch(int[] array, int index, int length, int searchingNum)
        {
            while (index <= length)
            {
                int middle = (length + index) / 2;

                if (array[middle] < searchingNum)
                {
                    index = middle + 1;
                }
                else if (array[middle] > searchingNum)
                {
                    length = middle - 1;
                }
                else
                {
                    return middle;
                }

            }
                throw new ArgumentException("Number not found!");
        }
    }
}
