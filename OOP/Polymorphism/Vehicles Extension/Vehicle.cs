namespace Vehicles_Extension
{
    using System;

    public abstract class Vehicle
    {

        private double tankCapacity;
        private double fuelQuantity;

        protected Vehicle(string vehicleType, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            VehicleType = vehicleType;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public string VehicleType { get; private set; }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            protected set
            {
                fuelQuantity = value;
            }
        }

        protected double FuelConsumption { get; set; }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set
            {
                if (value < fuelQuantity)
                {
                    value = 0;
                }
                tankCapacity = value;
            }
        }

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
            if (refulledFuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return fuelQuantity;
            }

            if (FuelQuantity + refulledFuel > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {refulledFuel} fuel in the tank");
                return FuelQuantity;
            }

            return FuelQuantity += refulledFuel;
        }

        public override string ToString()
        {
            return $"{VehicleType}: {FuelQuantity:f2}".ToString();
        }

       
    }
}
