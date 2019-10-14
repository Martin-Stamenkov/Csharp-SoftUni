using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Tire
    {
        public double Pressure { get; set; }

        public int Year { get; set; }

        public Tire(double pressure, int year)
        {
            this.Pressure = pressure;

            this.Year = year;
        }
    }
}
