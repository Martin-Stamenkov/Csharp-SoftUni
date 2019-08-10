using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyDigit = int.Parse(Console.ReadLine());
            bool flag = false;
            bool flag1 = false;

            for (int firsDiggitPlus = 1; firsDiggitPlus <= 30; firsDiggitPlus++)
            {
                for (int secondDiggitPlus = 1; secondDiggitPlus <= 30; secondDiggitPlus++)
                {
                    for (int thirdDiggitPlus = 1; thirdDiggitPlus <= 30; thirdDiggitPlus++)
                    {

                        if (firsDiggitPlus < secondDiggitPlus && secondDiggitPlus < thirdDiggitPlus)
                        {
                            if (firsDiggitPlus + secondDiggitPlus + thirdDiggitPlus == keyDigit)

                            {
                                Console.WriteLine($"{firsDiggitPlus} + {secondDiggitPlus} + {thirdDiggitPlus} = {keyDigit}");
                            }
                        }
                        if (firsDiggitPlus > secondDiggitPlus && secondDiggitPlus > thirdDiggitPlus)

                        {
                            if (firsDiggitPlus * secondDiggitPlus * thirdDiggitPlus == keyDigit)
                            {

                                Console.WriteLine($"{firsDiggitPlus} * {secondDiggitPlus} * {thirdDiggitPlus} = {keyDigit}");
                            }
                        }

                    }
                }
            }
            if (flag==false && flag1 == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
