using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Shortage
{
    public class Rebel : IBuyer
    {
        private int food;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Group { get; set; }

        public int Food => food;

        public void BuyFood()
        {
            food += 5;
        }
    }
}
