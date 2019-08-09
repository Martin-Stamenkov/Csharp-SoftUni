using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int max = int.MinValue;
            string nameWiner = string.Empty;

            while (name != "STOP")
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    char symbol = name[i];
                    sum += symbol;

                }
                if (sum > max)
                {
                    max = sum;
                    nameWiner = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {nameWiner} - {max}!");
        }
    }
}
