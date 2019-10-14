using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                var infoLine = Console.ReadLine()
                    .Split();
                var model = infoLine[0];
                var engineSpeed = int.Parse(infoLine[1]);
                var enginePower = int.Parse(infoLine[2]);
                var cargoWeight = int.Parse(infoLine[3]);
                var cargoType = infoLine[4];

                var tires = new Tire[4];
                int counter = 0;

                for (int j = 5; j < infoLine.Length; j+=2)
                {
                    var tirePresure = double.Parse(infoLine[j]);
                    var tireYear = int.Parse(infoLine[j + 1]);

                    var tire = new Tire(tirePresure, tireYear);
                    tires[counter++]= tire;
                }
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType == command && car.Tire.Any(x=>x.Pressure<1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType == command && car.Engine.EnginePower>250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }

        } 
    }
  
}
