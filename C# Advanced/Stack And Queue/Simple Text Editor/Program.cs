using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            int n = int.Parse(Console.ReadLine());

            string empty = "";

            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var currentCommand = commands[0];

                if (currentCommand=="1")
                {
                    var someText = commands[1];
                    stack.Push(empty);
                    empty += someText;
                }
                else if (currentCommand=="2")
                {
                    int count = int.Parse(commands[1]);
                    stack.Push(empty);
                empty = empty.Substring(0, empty.Length - count);
                    
                }
                else if (currentCommand == "3")
                {
                    int index = int.Parse(commands[1]);
                    Console.WriteLine(empty[index-1]);
                }
                else if (currentCommand=="4")
                {
                   empty = stack.Pop();
                }
            }
        }
    }
}
