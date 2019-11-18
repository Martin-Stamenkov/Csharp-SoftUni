namespace Vehicles
{
    public class Car : Vehicle
    {
        const double AirContitionConsumption = 0.9;

        public Car(string vehicleType, double fuelQuantity, double fuelConsumption) 
            : base(vehicleType, fuelQuantity, fuelConsumption)
        {
            FuelConsumption += AirContitionConsumption;
        }
    }
}
