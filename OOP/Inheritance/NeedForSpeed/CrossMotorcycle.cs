using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class CrossMotorcycle : Motorcycle
    {
        public const double DefaultFuelConsumption = 1.25;

        public CrossMotorcycle(int hp,double fuel)
            : base (hp,fuel)
        {

        }
    }
}
