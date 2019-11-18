using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class FamilyCar : Car
    {
       public const double DefaultFuelConsumption = 1.25;

        public FamilyCar(int hp, double fuel)
            : base (hp,fuel)
        {
                
        }
    }
}
