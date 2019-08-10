using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBatch = int.Parse(Console.ReadLine());
            string products = string.Empty;

            for (int i = 0; i <= numBatch; i++)
            {
                products = Console.ReadLine();
                while (products == "flour" || products == "eggs" || products == "sugar")
                {
                    if (products == "Bake")
                    {
                        if (products == "flour" && products == "eggs" && products == "sugar")
                        {
                            Console.WriteLine($"Baking batch number {i} …");
                           
                        }
                        if ((products != "flour" || products != "eggs" || products != "sugar"))
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                    products = Console.ReadLine();

                    
                }
            }
        }
    }
}
