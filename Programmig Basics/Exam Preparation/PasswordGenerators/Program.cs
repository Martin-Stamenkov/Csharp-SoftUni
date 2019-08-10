using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreNestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int firstDiggit = 1; firstDiggit <= num1; firstDiggit++)
            {
                for (int secondDiggit = 1; secondDiggit <= num2; secondDiggit++)
                {
                    for (int thirdDiggit = 1; thirdDiggit <= num3; thirdDiggit++)
                    {
                        if (firstDiggit % 2 == 0 && thirdDiggit % 2 == 0)
                        {
                            if (secondDiggit == 2 || secondDiggit == 3 || secondDiggit == 5 || secondDiggit == 7)
                            {
                                Console.WriteLine($"{firstDiggit}{secondDiggit}{thirdDiggit}");
                            }
                        }
                    }
                }
            }
        }
    }
}
