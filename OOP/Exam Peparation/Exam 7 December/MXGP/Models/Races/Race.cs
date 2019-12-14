using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders.Contracts;
using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Models.Races
{
    public class Race : IRace
    {
        private string name;
        private int laps;
        private readonly List<IRider> riders;

        public Race(string name, int laps)
        {
            Name = name;
            Laps = laps;
            riders = new List<IRider>(); 
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

        public int Laps
        {
            get { return laps; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidNumberOfLaps, 1));
                }
                laps = value;
            }
        }

        public IReadOnlyCollection<IRider> Riders => riders.AsReadOnly();

        public void AddRider(IRider rider)
        {
            if (rider == null)
            {
                throw new ArgumentException(ExceptionMessages.RiderInvalid);
            }
            if (rider.CanParticipate == false)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RiderNotParticipate, rider.Name));
            }
            if (riders.Contains(rider))
            {
                throw new ArgumentNullException(string.Format(ExceptionMessages.RiderAlreadyAdded, rider.Name,Name));
            }
            riders.Add(rider);
        }
    }
}
