using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> calculator = Console.ReadLine().Split(" ").Reverse().ToList();

            Stack<string> stack = new Stack<string>(calculator);


            while (stack.Count>1)
            {
                int firstNum = int.Parse(stack.Pop());
                char @operator = char.Parse(stack.Pop());
                int secondNum = int.Parse(stack.Pop());

                if (@operator=='+')
                {
                    stack.Push((firstNum + secondNum).ToString());
                }
                else if (@operator=='-')
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
