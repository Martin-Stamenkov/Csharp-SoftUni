using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        private int Age
        {
            get { return age; }
            set
            {
                if (value  >= 0)
                {
                    age = value;
                }
                
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Name: {Name}, Age: {Age}");

            return sb.ToString();
        }

    }
}
