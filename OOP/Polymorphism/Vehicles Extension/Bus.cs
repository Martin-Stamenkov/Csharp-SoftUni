using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_Extension
{
    public class Bus : Vehicle
    {
        const double AirContitionConsumption = 1.4;

        public Bus(string vehicleType, double fuelQuantity, double fuelConsumption , double tankCapacity)
            : base(vehicleType, fuelQuantity, fuelConsumption,tankCapacity)
        {
            
        }

        public double DriveWithPeople(double travelledDistance)
        {
            FuelConsumption += AirContitionConsumption;

            double currentFuel = FuelQuantity - FuelConsumption * travelledDistance;

            if (currentFuel >= 0)
            {
                FuelQuantity -= FuelConsumption * travelledDistance;
                Console.WriteLine($"{VehicleType} travelled {travelledDistance} km");
            }
            else
            {
                Console.WriteLine($"{VehicleType} needs refueling");
            }

            return FuelConsumption -= AirContitionConsumption;
        }

    }
}
