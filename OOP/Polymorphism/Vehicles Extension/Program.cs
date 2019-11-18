using System;

namespace Vehicles_Extension
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var carFuelQuantity = double.Parse(carInfo[1]);
            var carFuelConsumption = double.Parse(carInfo[2]);
            var carTankCapacity = int.Parse(carInfo[3]);

            Car car = new Car(carInfo[0], carFuelQuantity, carFuelConsumption,carTankCapacity);

            var truckInfo = Console.ReadLine()
                .Split(" ");

            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckFuelConsumption = double.Parse(truckInfo[2]);
            var truckTankCapacity = int.Parse(truckInfo[3]);

            Truck truck = new Truck(truckInfo[0], truckFuelQuantity, truckFuelConsumption,truckTankCapacity);

            var busInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var busFuelQuantity = double.Parse(busInfo[1]);
            var busFuelConsumption = double.Parse(busInfo[2]);
            var busTankCapacity = int.Parse(busInfo[3]);

            Bus bus = new Bus(busInfo[0], busFuelQuantity, busFuelConsumption, busTankCapacity);

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
                    else if (currentVehicle == "Bus")
                    {
                        bus.DriveWithPeople(fuelOrDistance);
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
                    else if (currentVehicle == "Bus")
                    {
                        bus.Refuel(fuelOrDistance);
                    }
                }
                else if (command == "DriveEmpty")
                {
                    bus.Drive(fuelOrDistance);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
