using System;
namespace Vehicles_Extension
{
    public class Truck : Vehicle
    {
        const double AirContitionConsumption = 1.6;

        public Truck(string vehicleType, double fuelQuantity, double fuelConsumption , double tankcapacity)
            : base(vehicleType, fuelQuantity, fuelConsumption , tankcapacity)
        {
            FuelConsumption += AirContitionConsumption;
        }

        public override double Refuel(double refulledFuel)
        {
            if (refulledFuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return FuelQuantity;
            }
            if (FuelQuantity + refulledFuel > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {refulledFuel} fuel in the tank");
                return FuelQuantity;
            }
            return FuelQuantity += refulledFuel * 0.95;
        }
    }
}
