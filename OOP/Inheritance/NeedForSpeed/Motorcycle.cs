using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Motorcycle : Vehicle
    {
       public  const double DefaultFuelConsumption = 1.25;

        public Motorcycle(int hp,double fuel)
            : base (hp,fuel)
        {

        }
    }
}
