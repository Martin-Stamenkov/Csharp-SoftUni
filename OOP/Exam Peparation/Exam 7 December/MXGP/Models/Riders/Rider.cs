using System;
using System.Collections.Generic;
using System.Text;
using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Riders.Contracts;
using MXGP.Utilities.Messages;

namespace MXGP.Models.Riders
{
    public class Rider : IRider
    {
        private string name;

        public Rider(string name)
        {
            Name = name;
            CanParticipate = false;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 5));
                }
                name = value;
            }
        }

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate { get; private set; }

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            if (motorcycle == null)
            {
                throw new ArgumentException(ExceptionMessages.MotorcycleInvalid);
            }

            Motorcycle = motorcycle;
            CanParticipate = true;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }
    }
}
