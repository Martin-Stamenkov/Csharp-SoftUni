namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pilot : IPilot
    {
        private string name;

        public Pilot(string name)
        {
            Name = name;
            this.machinesCollection = new List<IMachine>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null or empty string.");
                }
                name = value;
            }        
        }

        private List<IMachine> machinesCollection;

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException("Null machine cannot be added to the pilot.");
            }
            machinesCollection.Add(machine);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} - {machinesCollection.Count} machines");

            foreach (var machine in machinesCollection)
            {
                sb.AppendLine($"- {machine.Name}");
                sb.AppendLine($" *Type: {machine.GetType().Name}");
                sb.AppendLine($" *Health: {machine.HealthPoints}");
                sb.AppendLine($" *Attack: {machine.AttackPoints}");
                sb.AppendLine($" *Defense: {machine.DefensePoints}");
                sb.AppendLine($" *Targets: {string.Join(" ",machine.Targets)}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
