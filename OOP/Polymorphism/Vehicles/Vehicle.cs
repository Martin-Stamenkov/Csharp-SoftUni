namespace Vehicles
{
    using System;
    
    public abstract class Vehicle
    {

        protected Vehicle(string vehicleType, double fuelQuantity, double fuelConsumption)
        {
            VehicleType = vehicleType;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public string VehicleType { get; private set; }

        public double FuelQuantity { get; protected set; }

        protected double FuelConsumption { get; set; }

        public double Drive(double travelledDistance)
        {
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

            return FuelConsumption;
        }

        public virtual double Refuel(double refulledFuel)
        {
            return FuelQuantity += refulledFuel;
        }

        public override string ToString()
        {
            return $"{VehicleType}: {FuelQuantity:f2}".ToString();
        }
    }
}
