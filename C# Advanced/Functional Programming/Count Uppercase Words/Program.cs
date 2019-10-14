using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string [] result = input.Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(x=>char.IsUpper(x[0])).ToArray();

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
