using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int firstDiggit = 1; firstDiggit<=9; firstDiggit++)
            {
                for (int secondDiggit = 1; secondDiggit <= 9; secondDiggit++)
                {
                    for (int thirdDiggit = 1; thirdDiggit <=9; thirdDiggit++)
                    {
                        for (int fourDiggit = 1; fourDiggit<=9; fourDiggit++)
                        {
                            for (int fiveDiggit = 1; fiveDiggit <=9; fiveDiggit++)
                            {
                                for (int sixDiggit = 0; sixDiggit <=9 ; sixDiggit++)
                                {
                                    int total = firstDiggit * secondDiggit * thirdDiggit * fourDiggit * fiveDiggit * sixDiggit;
                                    if (total == num)
                                    {
                                        Console.Write($"{firstDiggit}{secondDiggit}{thirdDiggit}{fourDiggit}{fiveDiggit}{sixDiggit} ");
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
