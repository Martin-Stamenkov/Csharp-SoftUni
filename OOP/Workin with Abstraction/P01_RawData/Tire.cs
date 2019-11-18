﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Tire
    {
        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }

        public double Pressure { get; set; }

        public int Age { get; set; }

        public List<Tire> tires;

        public void Add(Tire tire)
        {
            tires.Add(tire);
        }

    }

}

