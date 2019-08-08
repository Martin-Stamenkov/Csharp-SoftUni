using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();

            string dayWeek = Console.ReadLine();

            double quantity = double.Parse(Console.ReadLine());

            double fruitPrice = 0;

            if (fruit == "banana" || fruit == "apple" || fruit == "kiwi" || fruit == "orange" || fruit == "grapefruit" || fruit == "pineaple" || fruit == "grapes")
                if (dayWeek == "Monday" || dayWeek == "Tuesday" || dayWeek == "Wednesday" || dayWeek == "Thursday" || dayWeek == "Friday")
                {
                    fruitPrice = 1.20;

                    fruitPrice = 0.85;

                    fruitPrice = 1.45;

                    fruitPrice = 2.70;

                    fruitPrice = 5.50;

                    fruitPrice = 3.85;

                    Console.WriteLine("{0:f2}", fruitPrice * quantity);
                }

                else if (dayWeek == "Saturday" || dayWeek == "Sunday")
                {
                    fruitPrice = quantity * 2.70;

                    fruitPrice = quantity * 1.25;

                    fruitPrice = quantity * 0.90;

                    fruitPrice = quantity * 1.60;

                    fruitPrice = quantity * 3.00;

                    fruitPrice = quantity * 5.60;


                    fruitPrice = quantity * 4.20;
                    Console.WriteLine("{0:f2}", fruitPrice * quantity);
                }

                else
                {
                    Console.WriteLine("error");
                }
            

            
   
        }
    }
}
