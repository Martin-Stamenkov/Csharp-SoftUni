using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Topping
    {
        private string name;
        private double weight;

        public Topping(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!ToppingRepository.IsValidName(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                name = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }       
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Name} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
        public double CalculateToppingCalories()
        {
            return 2 * Weight * ToppingRepository.GetTopingModifier(Name);
        }

    }
}
