using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChalengeTheWeeding
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMen = int.Parse(Console.ReadLine());
            int numWomen = int.Parse(Console.ReadLine());
            int numTables = int.Parse(Console.ReadLine());
            int totalcount = 0;

            for (int firsTicket = 1; firsTicket <= numMen; firsTicket++)
            {
                for (int secondTicket = 1; secondTicket <= numWomen; secondTicket++)
                {
                    
                    if (totalcount == numTables)
                    {
                        break;
                    }
                    Console.Write($"({firsTicket} <-> {secondTicket}) ");
                    totalcount++;
                }
            }

        }
    }
}
