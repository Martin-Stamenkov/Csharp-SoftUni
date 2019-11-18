using Military_Elite.Contracts;
using Military_Elite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps, ICollection<IRepair> repairs) 
            : base(id,firstName,lastName,salary,corps)
        {
            Repairs = repairs;
        }

        public ICollection<IRepair> Repairs { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Name: {FirstName} {LastName} Id: {Id} Salary: {Salary}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine($"Repairs: ");

            foreach (var repair in Repairs)
            {
                sb.AppendLine($"  Part Name: {repair.Name} Hours Worked: {repair.HoursWorked}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
