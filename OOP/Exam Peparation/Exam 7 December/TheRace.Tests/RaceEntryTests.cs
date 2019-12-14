using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        UnitMotorcycle unitMotorcycle;
        UnitRider unitRider;
        RaceEntry raceEntry;

        private const string Model = "Suzuiki";
        private const int HP = 50;
        private const double CubicCm = 20.5;

        private const string Name = "Pesho";

       [SetUp]
        public void Setup()
        {
            unitMotorcycle = new UnitMotorcycle(Model, HP, CubicCm);
            unitRider = new UnitRider(Name, unitMotorcycle);
            raceEntry = new RaceEntry();
        }
        [Test]
        public void Test_Constructors()
        {
            Assert.AreEqual(Model, unitMotorcycle.Model);
            Assert.AreEqual(HP, unitMotorcycle.HorsePower);
            Assert.AreEqual(CubicCm,unitMotorcycle.CubicCentimeters);

            Assert.AreEqual(Name , unitRider.Name);
        }
        [Test]
        public void Test_AddRider_And_Count()
        {
            raceEntry.AddRider(unitRider);

            Assert.AreEqual(1, raceEntry.Counter);                       
        }
        [Test]
        public void Test_Should_Throw_InvalidOperationException()
        {            
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddRider(null));
            raceEntry.AddRider(unitRider);
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddRider(unitRider));
            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }
        [Test]
        public void Test_CalculateAverageHorsePower()
        {

            unitMotorcycle = new UnitMotorcycle("Suzuki", 50, 20.50);
            raceEntry.AddRider(unitRider);
            raceEntry.AddRider(new UnitRider("Gosho", unitMotorcycle));

            Assert.AreEqual(50, raceEntry.CalculateAverageHorsePower());
        }        
    }
}