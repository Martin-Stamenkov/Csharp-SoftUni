using System;
using System.Collections.Generic;
using System.Linq;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < symbols.Length; i++)
            {
                char currentSymbol = symbols[i];

                if (currentSymbol == '(')
                {
                    stack.Push(i);
                }
                else if (currentSymbol == ')')
                {
                   int startIndex = stack.Pop();
                    string output =  symbols.Substring(startIndex, i-startIndex+1);
                    Console.WriteLine(output);

                }
            }
        }
    }
}
