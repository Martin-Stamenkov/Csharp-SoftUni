namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    public class PresentsTests
    {
        List<Present> presents;
        Present present1;
        Bag bag;

        [SetUp]
        public void Setup()
        {
            bag = new Bag();
            presents = new List<Present>();
            present1 = new Present("Bear", 20);
        }
       [Test]
       public void Test_Constructor()
      {
           Assert.AreEqual(0 , presents.Count);
       }
        [Test]
        public void Test_Create()
        {         
            Assert.AreEqual($"Successfully added present {present1.Name}.", bag.Create(present1));
        }
        [Test]
        public void Test_Create_ShouldThrowArgumentNullException_if_Present_Is_null()
        {
            Assert.Throws<ArgumentNullException>(() => bag.Create(null));
        }
        [Test]
        public void Test_Create_InvalidOperationException_if_PresentExist()
        {
            bag.Create(present1);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present1));
        }
        [Test]
        public void Test_Remove_true()
        {
            bag.Create(present1);        
            Assert.AreEqual(bag.Remove(present1),true);
        }
        [Test]
        public void Test_Remove_False()
        {
            bag.Create(present1);
            Assert.AreEqual(bag.Remove(new Present("Truck",20)), false);
        }
        [Test]
        public void Test_GetPresentWithLeastMagic()
        {
            bag.Create(present1);
            var present2 = new Present("Truck", 10);
            bag.Create(present2);
            Assert.AreEqual(bag.GetPresentWithLeastMagic(),present2);
        }
        [Test]
        public void Test_GetPresent()
        {
            bag.Create(present1);
            Assert.AreEqual(bag.GetPresent("Bear"), present1);
        }
        [Test]
        public void Test_GetPresents()
        {
            bag.Create(present1);
            presents.Add(present1);
            CollectionAssert.AreEqual(presents, bag.GetPresents());
        }
    }
}
