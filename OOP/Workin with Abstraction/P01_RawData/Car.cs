using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tire { get; set; }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tire)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tire = tire;
        }
    }
}