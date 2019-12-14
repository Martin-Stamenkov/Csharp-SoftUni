using MXGP.Models.Motorcycles.Contracts;
using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public abstract class Motorcycle : IMotorcycle
    {
        private string model;
        private int horsePower;

        protected Motorcycle(string model, int horsePower, double cubicCentimeters)
        {
            Model = model;
            HorsePower = horsePower;
            CubicCentimeters = cubicCentimeters;
        }

        public string Model
        {
            get { return model; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidModel,value,4));
                }
                model = value;
            }
        }
        public virtual int HorsePower
        {
            get { return horsePower; }
            protected set { horsePower = value;}
        }

        public  double CubicCentimeters { get; private set; }
       
        public double CalculateRacePoints(int laps)
        {
            var racePoints = CubicCentimeters / HorsePower * laps;
            return racePoints;
        }
    }
}
