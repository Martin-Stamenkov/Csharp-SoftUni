namespace Tests
{
    //using CarManager;
    using NUnit.Framework;
    using System;

    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MethodShouldTestTheConstructors()
        {
           string make = "Audi";
           string model = "A4";
           double fuelConsumption = 2.5;
           double fuelCapacity = 10;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
        }
        [TestCase(null, "A4" , 10 , 20)]
        [TestCase("Audi", null , 10 , 20)]
        [TestCase("Audi", "A4" , 0 , 20)]
        [TestCase("Audi", "A4" , -1 , 20)]
        [TestCase("Audi", "A4" , 10 , 0)]
        [TestCase("Audi", "A4" , 10 , -1)]
        public void MethodShouldThrowArgumentExceptionIfPropertiesIsNotValid(string model,string make,double fuelConsumption , double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }
        [Test]
        public void MethodShouldTestRefuelMethod()
        {
            string make = "Audi";
            string model = "A4";
            double fuelConsumption = 2.5;
            double fuelCapacity = 10;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(5);

            var expectedfuelAmount = 5;
            var actualfuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedfuelAmount, actualfuelAmount);
        }
        [Test]
        public void MethodShouldTestRefuelOverCapacity()
        {
            string make = "Audi";
            string model = "A4";
            double fuelConsumption = 2.5;
            double fuelCapacity = 10;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(20);

            var expectedfuelAmount = 10;
            var actualfuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedfuelAmount, actualfuelAmount);
        }
        [TestCase(0)]
        [TestCase(-5)]
        public void MethodShouldThrowArgumentExceptionIfFuelAmountIsNegativeOrZero(double fuelAmount)
        {
            string make = "Audi";
            string model = "A4";
            double fuelConsumption = 2.5;
            double fuelCapacity = 10;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.Throws<ArgumentException>(() => car.Refuel(fuelAmount));
        }
        [Test]
        public void MethodShouldTestDriveMethod()
        {
            string make = "Audi";
            string model = "A4";
            double fuelConsumption = 2.5;
            double fuelCapacity = 10;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(20);
            car.Drive(20);

            var expectedfuelAmount = 9.5;
            var actualfuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedfuelAmount, actualfuelAmount);
        }
        [Test]
        public void MethodShouldThrowInvalidOperationExceptionIfWeHaventEnoughFueltoDrive()
        {
            string make = "Audi";
            string model = "A4";
            double fuelConsumption = 2.5;
            double fuelCapacity = 10;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.Throws<InvalidOperationException>(() => car.Drive(20));
        }
    }
}