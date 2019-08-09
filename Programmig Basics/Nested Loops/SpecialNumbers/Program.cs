using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int diggit = 0;
            bool isSpecial = true;

            for (int i = 1111; i <= 9999; i++)
            {
                int number = i;
                int counter = 1;
                while (counter <= 4)
                {
                    diggit = number % 10;
                    number = number / 10;
                    if (diggit > 0)
                    {
                        if (n % diggit != 0)
                        {
                            isSpecial = false;
                        }
                    }
                    else
                    {
                        isSpecial = false;
                    }
                    counter++;
                }
                if (isSpecial)
                {
                    Console.Write(i + " ");
                }
                isSpecial = true;
                
            }
        }
    }
}
