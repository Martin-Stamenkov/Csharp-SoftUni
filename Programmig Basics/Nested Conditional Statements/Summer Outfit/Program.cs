using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string timeOftheDay = Console.ReadLine();
            string Outfit = string.Empty;
            string Shoes = string.Empty;
            if (10 <= temp && temp <= 18)
            {
                if (timeOftheDay == "Morning")
                {
                    Outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if (timeOftheDay == "Afternoon")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (timeOftheDay == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                if (18 < temp && temp <= 24)
                {
                    if (timeOftheDay == "Morning")
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                    }
                    else if (timeOftheDay == "Afternoon")
                    {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                    }
                    else if (timeOftheDay == "Evening")
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                    }

                }
                if (temp >= 25)
                {
                    if (timeOftheDay == "Morning")
                    {
                        Outfit = "T-Shirt";
                        Shoes = "sandals";
                    }
                    else if (timeOftheDay == "Afternoon")
                    {
                        Outfit = "Swim suit";
                        Shoes = "Barefoot";
                    }
                    else if (timeOftheDay == "Evening")
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                    }

                }
            }

            Console.WriteLine("It`s {0} degrees, get your {1} and {2}.", temp, Outfit, Shoes);                
            
        }
    }
}
            


       