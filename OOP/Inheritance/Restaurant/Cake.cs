using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {

        private const double dessertGrams = 250; 
        private const double dessertCalories = 1000;
        private const decimal cakePrice = 5;

        public Cake(string name)
           : base(name, cakePrice, dessertGrams, dessertCalories)
        {

        }
    }
}
