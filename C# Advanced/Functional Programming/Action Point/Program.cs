using System;
using System.Linq;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");

            Action<string[]> action = item => Console.WriteLine(string.Join(Environment.NewLine,item));

           action(names);
        }
    }
}
