﻿using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Dwarfs
{
    public abstract class Dwarf : IDwarf
    {
        private string name;
        private int energy;
        private readonly List<IInstrument> instruments;

        protected Dwarf(string name, int energy)
        {
            Name = name;
            Energy = energy;
            instruments = new List<IInstrument>();
        }

        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDwarfName);
                }
                name = value;
            }
        }
        //Todo
        public int Energy
        {
            get { return energy; }
            protected set
            {
                if (value < 0)
                {
                    value = 0;
                }
                energy = value;
            }
        }
        public ICollection<IInstrument> Instruments => instruments.AsReadOnly();
        public void AddInstrument(IInstrument instrument)
        {
            instruments.Add(instrument);
        }

        public abstract void Work();
      
    }
}
