using System;

namespace CarManufacturer
{
    public static class StartUp
    {
       public static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }

       public class Car
        {
  
            public string Make { get; set; }

            public string Model { get; set; }

            public int Year { get; set; }

            public double FuelQuantity { get; set; }

            public double FuelConsumption { get; set; }

            public void Drive(double distance)
            {
                double fuel = FuelQuantity - distance * FuelConsumption;
                if (fuel > 0)
                {
                    FuelQuantity -= (distance * FuelConsumption);
                }
                else
                {
                    Console.WriteLine("Not enough fuel to perform this trip!");
                }
            }
            public string  WhoAmI()
            {
                return ($"Make: { this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L");

            }

        }
    }
}

