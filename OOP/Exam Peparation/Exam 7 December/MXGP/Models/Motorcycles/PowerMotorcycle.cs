using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const double InitialcubicCm = 450;

        public PowerMotorcycle(string model, int horsePower) 
            : base(model, horsePower, InitialcubicCm)
        {
        }

        public override int HorsePower
        {
            get => base.HorsePower;
            protected set
            {
                if (value < 70 || value > 100)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower,value));
                }
                base.HorsePower = value;
            }
        }
    }
}
