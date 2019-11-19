﻿using System;

namespace CarManufacturer
{ 
  public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            Car car = new Car();
            Car secondCar = new Car(make,model,year);
            Car thirdCar = new Car(make,model,year,fuelQuantity,fuelConsumption);
        }
    }
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

       public Car()
       {
          //Make = "VW";
          //Model = "Golf";
          //Year = 2025;
          //FuelQuantity = 250;
          //FuelConsumption = 10;
           
       }

        public Car(string make, string model, int year )
            : this ()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
      
           this.FuelQuantity = fuelQuantity;
           this.FuelConsumption = fuelConsumption;
        }

        public string Make
        {
            get { return make; } 
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

    }

}