namespace Military_Elite.Models
{
    using System.Collections.Generic;
    using System.Text;

    using Contracts;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, Dictionary<int, IPrivate> privates)
            : base(id, firstName, lastName, salary)
        {
            Privates = privates;
        }

        public Dictionary<int, IPrivate> Privates { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary}");
            sb.AppendLine($"Privates: {Privates}");

            foreach (var @private in Privates)
            {
                sb.AppendLine($"Name:{@private.Value.FirstName} {@private.Value.LastName} Id: {@private.Key} Salary: {@private.Value.Salary:f2}");
            }
            
            return sb.ToString().TrimEnd();
        }
    }
}
