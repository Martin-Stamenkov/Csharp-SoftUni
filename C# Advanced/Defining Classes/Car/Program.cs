using System;

namespace CarManufacturer
{
  public  class StartUp
    {
       public static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make: { car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
        
    }
}
