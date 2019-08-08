using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            if (animal == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animal == "crocodile")
            {
                Console.WriteLine("reptile");
            }
            else if (animal == "snake")
            {
                Console.WriteLine("reptile");
            }
            else if (animal == "tortoise")

            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }

            
        }
    }
}
