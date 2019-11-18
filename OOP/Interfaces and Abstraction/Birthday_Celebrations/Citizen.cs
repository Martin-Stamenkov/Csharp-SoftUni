using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations
{
    public class Citizen : Iidentifible, IBirthable
    {
        public Citizen(string name, int age, string id,string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; }

        public string Birthdate { get; }
    }
}
