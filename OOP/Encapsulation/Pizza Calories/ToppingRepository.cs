using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public static class ToppingRepository
    {
        private static Dictionary<string, double> toppings;

        public static bool IsValidName(string type)
        {
            Initilaize();
            return toppings.ContainsKey(type.ToLower());
        }

        public static double GetTopingModifier(string type)
        {
            Initilaize();
            return toppings[type.ToLower()];
        }

        public static void Initilaize()
        {
            if (toppings != null)
            {
                return;
            }

            toppings = new Dictionary<string, double>();
            toppings.Add("meat", 1.2);
            toppings.Add("veggies", 0.8);
            toppings.Add("cheese", 1.1);
            toppings.Add("sauce", 0.9);
        }
    }
}
