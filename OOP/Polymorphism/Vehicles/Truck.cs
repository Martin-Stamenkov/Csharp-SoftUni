using System;
using System.Collections.Generic;
using System.Text;
namespace Vehicles
{
    public class Truck : Vehicle
    {
        const double AirContitionConsumption = 1.6; 

        public Truck(string vehicleType, double fuelQuantity, double fuelConsumption) 
            : base(vehicleType, fuelQuantity, fuelConsumption)
        {
            FuelConsumption += AirContitionConsumption;
        }

        public override double Refuel(double refulledFuel)
        {
            return FuelQuantity += refulledFuel * 0.95;
        }
    }
}
