using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private List<Topping> PizzaToppings;

        public Pizza(string name,Dough dough)
        {
            Dough = dough;
            Name = name;
            PizzaToppings = new List<Topping>();
        }

        public Dough Dough { get;}

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public int Count { get => PizzaToppings.Count; }

        public void AddToping(Topping topping)
        {
            if (PizzaToppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            PizzaToppings.Add(topping);
        }

        public double SumTotalCaloriesOfPizza()
        {
            return this.PizzaToppings.Sum(c => c.CalculateToppingCalories()) + this.Dough.GetTotalCalories();

        }

    }
}
