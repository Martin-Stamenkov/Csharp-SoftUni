using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double percentComission = 0;

            if (town == "Sofia")
            {
                if (sales > 0 && sales < 500)
                {
                    percentComission = sales * 0.05;
                    Console.WriteLine("{0:f2}", percentComission);
                }
                else if (sales > 500 && sales < 1000)
                {
                    percentComission = sales * 0.07;
                    Console.WriteLine("{0:f2}", percentComission);
                }
                else if (sales > 1000 && sales < 10000)
                {
                    percentComission = sales * 0.08;
                    Console.WriteLine("{0:f2}", percentComission);

                }
                else if (sales > 10000)
                {
                    percentComission = sales * 0.12;
                    Console.WriteLine("{0:f2}", percentComission);
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine();
            }

            else if (town == "Varna")
            {
                if (sales > 0 && sales < 500)
                {
                    percentComission = sales * 0.045;
                    Console.WriteLine("{0:f2}", percentComission);
                }
                else if (sales > 500 && sales < 1000)
                {
                    percentComission = sales * 0.075;
                    Console.WriteLine("{0:f2}", percentComission);
                }
                else if (sales > 1000 && sales < 10000)
                {
                    percentComission = sales * 0.10;
                    Console.WriteLine("{0:f2}", percentComission);
                }
                else if (sales > 10000)
                {
                    percentComission = sales * 0.13;
                    Console.WriteLine("{0:f2}", percentComission);
                }

            }
            else if (town == "Plovdiv")
            {
                if (sales > 0 && sales < 500)
                {
                    percentComission = sales * 0.055;
                    Console.WriteLine("{0:f2}", percentComission);
                }
                else if (sales > 500 && sales < 1000)
                {
                    percentComission = sales * 0.08;
                    Console.WriteLine("{0:f2}", percentComission);
                }
                else if (sales > 1000 && sales < 10000)
                {
                    percentComission = sales * 0.12;
                    Console.WriteLine("{0:f2}", percentComission);
                }
                else if (sales > 10000)
                {
                    percentComission = sales * 0.0145;

                }

            }
        }

    }
}
