using System;

namespace Recursion
{
    public class Program
    {
        private static void Recursion(int a)
        {
            a += 1;

            Console.WriteLine(a);
            if (a == 10)
            {
                return;
            }

            Recursion(a);
        }

        static void Main(string[] args)
        {
            int a = 5;

            Recursion(a);
        }
    }
}
