using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DummyTests
    {               
        private const int DummyHealth = 10;
        private const int DummyExperience = 10;
        
        [Test]
        public void DummyLossesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(DummyHealth, DummyExperience);

            dummy.TakeAttack(2);

            int exceptedHealth = 8;
            int actualHealth = dummy.Health;

            Assert.AreEqual(exceptedHealth, actualHealth);

        }
        
       [Test]
       public void DeadDummyThrowsExceptionIfAttacked()
       {
            Dummy dummy = new Dummy(DummyHealth, DummyExperience);
            int attackPoints = 6;

            while (!dummy.IsDead())
           {
               dummy.TakeAttack(attackPoints);
       
           }
           Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(attackPoints));
       }
       
       [Test]
       public void DeadDummyCanGiveExperience()
       {
            Dummy dummy = new Dummy(DummyHealth, DummyExperience);
            int AttackPoints = 10;

           while (!dummy.IsDead())
           {
               dummy.TakeAttack(AttackPoints);
           }
       
           var gotExperience = dummy.GiveExperience();
       
           Assert.AreEqual(gotExperience, DummyExperience);
       
       }
       
       [Test]
       public void AliveDummyCannotGiveExperience()
       {
           Dummy dummy = new Dummy(DummyHealth, DummyExperience);

           Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
           
       }
    }
}
