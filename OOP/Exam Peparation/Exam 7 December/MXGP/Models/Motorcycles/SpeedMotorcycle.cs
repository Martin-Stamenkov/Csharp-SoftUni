using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const double InitialcubicCm = 125;

        public SpeedMotorcycle(string model, int horsePower) 
            : base(model, horsePower, InitialcubicCm)
        {
        }
        public override int HorsePower
        {
            get => base.HorsePower;
            protected set
            {
                if (value < 50 || value > 69)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }
                base.HorsePower = value;
            }
        }
    }
}
