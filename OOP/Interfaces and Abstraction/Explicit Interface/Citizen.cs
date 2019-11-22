using System;
using System.Collections.Generic;
using System.Text;

namespace Explicit_Interface
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string coutry, int age)
        {
            Name = name;
            Coutry = coutry;
            Age = age;
        }

        public string Name { get; }

        public string Coutry { get; }

        public int Age { get; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";

        }

        string IPerson.GetName()
        {
            return Name;
        }
    }
}
