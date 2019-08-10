using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());

            for (int firstDiggit =  startNumber; firstDiggit <= finalNumber ; firstDiggit++)
            {
                for (int secondDiggit = startNumber; secondDiggit <=finalNumber ; secondDiggit++)
                {
                    for (int thirdDiggit = startNumber; thirdDiggit <= finalNumber; thirdDiggit++)
                    {
                        for (int fourDiggit = startNumber ; fourDiggit <= firstDiggit; fourDiggit++)
                        {
                            if (firstDiggit % 2 == 0 && fourDiggit % 2 == 1 || firstDiggit % 2 == 1 && fourDiggit % 2 == 0)
                            {
                                if ((secondDiggit+thirdDiggit)%2==0)
                                {
                                    if (firstDiggit>fourDiggit)
                                    {
                                        Console.Write($"{firstDiggit}{secondDiggit}{thirdDiggit}{fourDiggit} ");
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
