using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = int.MinValue;
            int smallest = int.MaxValue;

            string command = Console.ReadLine();

                
            while (command != "END")
            {
                int number = int.Parse(command);
                if (number > largest)
                {
                    largest=number;
                }
                if (number < smallest)
                {
                    smallest=number;
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"Max number: {largest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
