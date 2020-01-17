namespace Aquariums.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;


    public class AquariumsTests
    {
        Fish fish;
        Aquarium aquarium;
        List<Fish> fishes;

         private const string name = "Aquarium";
         private const string nameFish = "Nemo";
         private const int capacity = 1;

        [SetUp]
        public void Setup()
        {
            fish = new Fish(nameFish);
            aquarium = new Aquarium(name, capacity);
            fishes = new List<Fish>();
        }
        [Test]
        public void Test_Constructor()
        {
            Assert.AreEqual(name, aquarium.Name);
            Assert.AreEqual(capacity, aquarium.Capacity);
            Assert.AreEqual(0, fishes.Count);
        }
        [Test]
        public void Test_Should_Throw_ArgumentNullException_if_Name_Is_NullirEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium("", capacity));
            Assert.Throws<ArgumentNullException>(() => new Aquarium(null, capacity));
        }
        [Test]
        public void Test_Should_Throw_ArgumentException_if_Capacity_is_Bellow_Zero()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium(name, -1));
        }
        [Test]
        public void Test_Should_Throw_InvalidOperationException_if_Capacity_is_Full()
        {
            aquarium.Add(fish);
            Assert.Throws<InvalidOperationException>(() => aquarium.Add(fish));
        }
        [Test]
        public void Test_AddMethod()
        {
            aquarium.Add(fish);
            Assert.AreEqual(1, aquarium.Count);
        }
        [Test]
        public void Test_RemoveMethod()
        {
            aquarium.Add(fish);
            aquarium.RemoveFish(nameFish);
            Assert.AreEqual(0, aquarium.Count);
        }
        [Test]
        public void Test_Should_Throw_InvalidOperationException_if_Remove_Not_ExictingFish()
        {
            aquarium.Add(fish);
            
            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish("Pesho"));
        }
        [Test]
        public void Test_Should_Throw_InvalidOperationException_if_Try_To_Find_Not_ExictingFish()
        {
            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish("Pesho"));
        }
        [Test]
        public void Test_SellMethod()
        {
            aquarium.Add(fish);
            Assert.AreEqual(aquarium.SellFish(nameFish), fish);
        }
        [Test]
        public void Test_ReportMethod()
        {
            aquarium.Add(fish);
            Assert.AreEqual(aquarium.Report(), $"Fish available at {name}: {fish.Name}");
        }

    }
}
