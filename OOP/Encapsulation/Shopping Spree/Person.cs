using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping_Spree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> bag;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public string Name
        {
            get { return name; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public int Money
        {
            get { return money; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public void AddToBag(Product item)
        {
            if (Money - item.Cost >= 0)
            {
                Money -= item.Cost;
                bag.Add(item);
                Console.WriteLine($"{Name} bought {item.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {item.Name}");
            }
        }

        public override string ToString()
        {
            if (bag.Count == 0)
            {
                return $"{Name} - Nothing bought ";
            }
            return $"{Name} - {string.Join(", ", bag.Select(x=>x.Name))}".ToString();
        }
    }
}
