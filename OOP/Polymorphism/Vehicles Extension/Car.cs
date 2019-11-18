namespace Vehicles_Extension
{
    public class Car : Vehicle
    {
        const double AirContitionConsumption = 0.9;

        public Car(string vehicleType, double fuelQuantity, double fuelConsumption , double tankCapacity)
            : base(vehicleType, fuelQuantity, fuelConsumption , tankCapacity)
        {
            FuelConsumption += AirContitionConsumption;
        }
    }
}
