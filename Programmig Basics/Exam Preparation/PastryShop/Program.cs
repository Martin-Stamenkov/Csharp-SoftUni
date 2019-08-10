using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string desert = Console.ReadLine();
            int numDeserts = int.Parse(Console.ReadLine());
            int dayOfMonth = int.Parse(Console.ReadLine());
            double desertsPrice = 0;
            double discount = 0;
            if (dayOfMonth <= 15)
            {

                if (desert == "Cake")
                {
                    desertsPrice = 24;
                }
                else if (desert == "Souffle")
                {
                    desertsPrice = 6.66;
                }
                else if (desert == "Baklava")
                {
                    desertsPrice = 12.60;
                }

                desertsPrice = desertsPrice * numDeserts;
                

            }
            else if (dayOfMonth > 15)
            {
                if (desert == "Cake")
                {
                    desertsPrice = 28.70;
                }
                else if (desert == "Souffle")
                {
                    desertsPrice = 9.80;
                }
                else if (desert == "Baklava")
                {
                    desertsPrice = 16.98;

                }
                desertsPrice = desertsPrice * numDeserts;
            }
            if (dayOfMonth <= 22 && (desertsPrice >= 100 && desertsPrice <= 200))
            {
                desertsPrice = desertsPrice - desertsPrice * 0.15;

            }
            else if (dayOfMonth <= 22 && desertsPrice > 200)
            {
                desertsPrice = desertsPrice - desertsPrice * 0.25;


            }
            if (dayOfMonth<=15)
            {
                desertsPrice = desertsPrice - desertsPrice * 0.10;
            }
           
            Console.WriteLine($"{desertsPrice:f2}");
        }
    }

}