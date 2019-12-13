namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    public class SpaceshipTests
    {
        Astronaut astronaut;
        Spaceship spaceship;
        
        [SetUp]
        public void Setup()
        {
            astronaut = new Astronaut("Gagarin", 60.50);
            spaceship = new Spaceship("Sokola", 2);
        }

        [Test]
        public void Test_Constructors()
        {
            Assert.AreEqual(astronaut.Name, "Gagarin");
            Assert.AreEqual(astronaut.OxygenInPercentage, 60.50);
            Assert.AreEqual(spaceship.Name, "Sokola");
            Assert.AreEqual(spaceship.Capacity, 2);
            Assert.AreEqual(0, spaceship.Count);
        }
        [Test]
        public void Method_Should_throw_ArgumentNullException_if_Name_is_NullorEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => new Spaceship(null,20));
        }
        [Test]
        public void Method_Should_throw_ArgumentException_if_Capacity_is_Negative()
        {
            Assert.Throws<ArgumentException>(() => new Spaceship("Sokola", -5));
        }
        [Test]
        public void Add_Method_Should_Work_Correctly_And_Count_Should_Increase()
        {
            spaceship.Add(astronaut);
            Assert.AreEqual(1,spaceship.Count);
            
        }
        [Test]
        public void Method_Should_throw_InvalidOtionperaException_if_Capacity_is_Full()
        {
            spaceship.Add(astronaut);
            spaceship.Add(new Astronaut("Stamenkov",70.60));
            Assert.Throws<InvalidOperationException>(() => spaceship.Add(new Astronaut("Ivanov",40.80)));
        }
        [Test]
        public void Method_Should_throw_InvalidOtionperaException_If_Astronaut_Already_Exist()
        {
            spaceship.Add(astronaut);
            Assert.Throws<InvalidOperationException>(() => spaceship.Add(astronaut));
        }
        [Test]
        public void Remove_Method_Should_Work_Correctly_And_Return_True()
        {
            spaceship.Add(astronaut);
            Assert.AreEqual(true, spaceship.Remove(astronaut.Name));

        }
        [Test]
        public void Remove_Method_Should_Work_Correctly_Return_False()
        {
            spaceship.Add(astronaut);
            Assert.AreEqual(spaceship.Remove("Ivanov"), false);
        }
    }
}