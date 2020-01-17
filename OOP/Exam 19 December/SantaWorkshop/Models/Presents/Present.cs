using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Presents
{
    public class Present : IPresent
    {
        private string name;
        private int energyRequired;

        public Present(string name, int energyRequired)
        {
            Name = name;
            EnergyRequired = energyRequired;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPresentName);
                }
                name = value;
            }
        }
        public int EnergyRequired
        {
            get { return energyRequired; }
             private set
            {
                if (value < 0)
                {
                    value = 0;
                }
                energyRequired = value;
            }
        }

        public void GetCrafted()
        {
            EnergyRequired -= 10;
        }
        // A present's required energy should not drop below 0.

        public bool IsDone()
        {
            return EnergyRequired == 0;
        }
    }
}
