using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Shortage
{
    public class Citizen : IBuyer
    {
        private int food = 0;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get;  set; }

        public int Age { get; private set; }

        public string Id { get; }

        public string Birthdate { get; }

        public int Food => food;

        public void BuyFood()
        {
            food += 10;
        }
    }
}
