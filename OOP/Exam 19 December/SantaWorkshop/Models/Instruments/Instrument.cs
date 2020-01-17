using SantaWorkshop.Models.Instruments.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Instruments
{
    public class Instrument : IInstrument
    {
        private int power;

        public Instrument(int power)
        {
            Power = power;
        }

        public int Power
        {
            get { return power; }
            private set 
            {
                if (value < 0)
                {
                    value = 0;
                }
                power = value;
            }
        }

        public bool IsBroken()
        {
            return Power == 0;
        }

        public void Use()
        {
            Power -= 10;
        }
    }
}
