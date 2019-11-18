using System;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            var carFuelQuantity = double.Parse(carInfo[1]);
            var carFuelConsumption = double.Parse(carInfo[2]);

            Car car = new Car(carInfo[0], carFuelQuantity, carFuelConsumption);

            var truckInfo = Console.ReadLine()
                .Split(" ");

            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckFuelConsumption = double.Parse(truckInfo[2]);

            Truck truck = new Truck(truckInfo[0], truckFuelQuantity, truckFuelConsumption);

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var infoLine = Console.ReadLine()
                    .Split(" ");
                var command = infoLine[0];
                var currentVehicle = infoLine[1];
                var fuelOrDistance = double.Parse(infoLine[2]);

                if (command == "Drive")
                {
                    if (currentVehicle == "Car")
                    {
                        car.Drive(fuelOrDistance);
                    }
                    else if (currentVehicle == "Truck")
                    {
                        truck.Drive(fuelOrDistance);
                    }

                }
                else if (command == "Refuel")
                {
                    if (currentVehicle == "Car")
                    {
                        car.Refuel(fuelOrDistance);
                    }
                    else if (currentVehicle == "Truck")
                    {
                        truck.Refuel(fuelOrDistance);
                    }
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
