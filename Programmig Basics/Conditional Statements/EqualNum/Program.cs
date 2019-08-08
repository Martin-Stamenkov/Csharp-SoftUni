using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a != b)
            {
                Console.WriteLine("no");
            }
            else if (a != c)
            {
                Console.WriteLine("no");
            }
            else if (b != c)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }

        }
    }
} 
