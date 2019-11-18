using Military_Elite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Repair : IRepair
    {
        public Repair(string name, int hoursWorked)
        {
            Name = name;
            HoursWorked = hoursWorked;
        }

        public string Name { get; }

        public int HoursWorked { get; }

        public override string ToString()
        {
            return $"Part Name: {Name} Hours Worked: {HoursWorked}".ToString();
        }
    }
}
