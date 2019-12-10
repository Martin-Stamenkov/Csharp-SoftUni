namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    public class SoftParkTest
    {
        private Car car1;
        private Car car2;
        private SoftPark softPark;

        [SetUp]
        public void Setup()
        {
            car1 = new Car("Audi", "123456");
            car2 = new Car("BMW", "7891011");
            softPark = new SoftPark();
        }

        [Test]
        public void ConstructorsShouldWorkCorrectly()
        {
            Assert.AreEqual("Audi", car1.Make);
            Assert.AreEqual("123456", car1.RegistrationNumber);
            Assert.AreEqual(12, softPark.Parking.Count);
        }
        [Test]
        public void MethodShouldThrowArgumentExceptionIfParkingSpotDoesntExist()
        {
            Assert.Throws<ArgumentException>(() => softPark.ParkCar("AA", car1));
        }
        [Test]
        public void MethodShouldThrowArgumentExceptionIfParkingSpotIsAlreadyTaken()
        {
            softPark.ParkCar("A1", car1);
            Assert.Throws<ArgumentException>(() => softPark.ParkCar("A1", car2));
        }
        [Test]
        public void MethodShouldThrowInvalidOperationExceptionIfCarIsAlreadyParked()
        {
            softPark.ParkCar("A1", car1);
            Assert.Throws<InvalidOperationException>(() => softPark.ParkCar("A2", car1));
        }
        [Test]
        public void MethodParkCarShouldWorkCorrectly()
        {
            Assert.AreEqual($"Car:{car1.RegistrationNumber} parked successfully!",softPark.ParkCar("A1",car1));
        }
        [Test]
        public void MethodShouldThrowArgumentExceptionIfRemoveFromNotExistingSpot()
        {
            Assert.Throws<ArgumentException>(() => softPark.RemoveCar("AA", car1));
        }
        [Test]
        public void MethodShouldThrowArgumentExceptionIfCarFromParkingSpotDoesntExist()
        {
            softPark.ParkCar("A1", car1);
            Assert.Throws<ArgumentException>(() => softPark.RemoveCar("A1", car2));
        }
        [Test]
        public void MethodRemoveShouldWorkCorrectly()
        {
            softPark.ParkCar("A1", car1);
            Assert.AreEqual($"Remove car:{car1.RegistrationNumber} successfully!", softPark.RemoveCar("A1", car1));
        }
    }
}