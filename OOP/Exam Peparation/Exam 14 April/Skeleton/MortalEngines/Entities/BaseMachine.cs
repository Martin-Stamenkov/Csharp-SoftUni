namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System;

    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;

        protected BaseMachine(string name, double healthPoints, double attackPoints, double defensePoints)
        {
            Name = name;
            HealthPoints = healthPoints;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Machine name cannot be null or empty.");
                }
                name = value;
            }
        }
        public IPilot Pilot
        {
            get { return pilot; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Pilot cannot be null.");
                }
                pilot = value;
            }
        }
        public double HealthPoints
        {
            get { return healthPoints; }
            set { healthPoints = value; }
        }
        public double AttackPoints
        {
            get { return attackPoints; }
            protected set { attackPoints = value; }
        }

        public double DefensePoints
        {
            get { return DefensePoints; }
            protected set { DefensePoints = value; }
        }

        public IList<string> Targets { get; }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                throw new NullReferenceException("Target cannot be null");
            }

            if (target.HealthPoints - (AttackPoints - target.DefensePoints) < 0)
            {
                target.HealthPoints = 0;

                Targets.Add(target.Name);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"- {Name}");
            sb.AppendLine($" *Type: {GetType().Name}");
            sb.AppendLine($" *Health: {HealthPoints}");
            sb.AppendLine($" *Attack: {AttackPoints}");
            sb.AppendLine($" *Defense: {DefensePoints}");
            if (Targets.Any())
            {
                sb.AppendLine(string.Join(",",Targets));
            }
            else
            {
                sb.AppendLine("None");
            }
            return base.ToString();
        }
    }
}
