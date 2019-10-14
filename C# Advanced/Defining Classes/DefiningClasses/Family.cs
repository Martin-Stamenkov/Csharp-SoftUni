using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
   public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddPeople(Person person)
        {
            this.people.Add(person);
        }
        public void GetOlderThanThirty()
        {
            var person = people.Where(x => x.Age > 30).OrderBy(x => x.Name).Select(x => $"{x.Name} - {x.Age}");

            Console.WriteLine(string.Join(Environment.NewLine,person));
            
        }
    }
}
