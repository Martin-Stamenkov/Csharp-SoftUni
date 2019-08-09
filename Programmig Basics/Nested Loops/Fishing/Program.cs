using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine());

            double priceFish = 0;
            double profit = 0;
            double lostMoney = 0;
            int sumFish = 0;

            string fishName = Console.ReadLine();

            for (int i = 1; i <=quota; i++)
            {

                for (int j = 0; j < fishName.Length; j++)
                {
                    sumFish += fishName[j];

                }

                double fishKg = double.Parse(Console.ReadLine());
                priceFish = sumFish / fishKg;
                sumFish = 0;
                if (i % 3 == 0)
                {
                    profit += priceFish;
                }
                else
                {
                    Math.Abs(lostMoney += priceFish);
                }
                if (quota == i)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    if (profit > lostMoney)
                    {
                        double totalProfit = profit - lostMoney;
                        Console.WriteLine($"Lyubo's profit from {i} fishes is {totalProfit:f2} leva.");
                    }
                    else if (lostMoney > profit)
                    {
                        double totalLostMoney = Math.Abs(lostMoney - profit);
                        Console.WriteLine($"Lyubo lost {totalLostMoney:f2} leva today.");
                    }
                }
                fishName = Console.ReadLine();
                if (fishName == "Stop")
                {
                    
                    if (profit > lostMoney)
                    {
                        double totalProfit = profit - Math.Abs(lostMoney);
                        Console.WriteLine($"Lyubo's profit from {i} fishes is {totalProfit:f2} leva.");
                        break;
                    }
                    else if (lostMoney>profit)
                    {
                        double totalLostMoney = Math.Abs(lostMoney - profit);
                        Console.WriteLine($"Lyubo lost {totalLostMoney:f2} leva today.");
                        break;
                    }
                }
               
            }


        }
    }
}
