using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int firsDiggit = 1; firsDiggit <= 9; firsDiggit++)
            {
                for (int secondDiggit = 1; secondDiggit <= 9; secondDiggit++)
                {
                    for (int thirdDiggit = 1; thirdDiggit <= 9; thirdDiggit++)
                    {
                        for (int fourDiggit = 1; fourDiggit <= 9; fourDiggit++)
                        {
                            if (firsDiggit+secondDiggit == thirdDiggit+fourDiggit)
                            {
                                if (num%(firsDiggit+secondDiggit)==0)
                                {
                                    Console.Write($"{firsDiggit}{secondDiggit}{thirdDiggit}{fourDiggit} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
