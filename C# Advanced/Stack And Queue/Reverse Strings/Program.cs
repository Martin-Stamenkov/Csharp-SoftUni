using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<char>(input);

                while (stack.Any())
                {

                     Console.Write(stack.Pop());
                }
            Console.WriteLine();
        }
    }
}
