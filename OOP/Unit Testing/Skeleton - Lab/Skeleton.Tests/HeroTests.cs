using NUnit.Framework;
using Skeleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestFixture]
    public class HeroTests
    {
        private const int FakeHealth = 10;
        private const int FakeGiveExpirience = 10;
        private const int FakeAttack = 10;

        private class FakeTarget : ITarget
        {
            public FakeTarget()
            {
                Health = FakeHealth;
            }

            public int Health { get; private set; }

            public int GiveExperience()
            {
                return FakeGiveExpirience;
            }

            public bool IsDead()
            {
                return Health <= 0;
            }

            public void TakeAttack(int attackPoints)
            {
                Health -= attackPoints;
            }
        }

        private class FakeWapon : IWeapon
        {
            public void Attack(ITarget target)
            {
                target.TakeAttack(FakeAttack);
            }
        }

        [Test]
        public void HeroGainsExpirienceWhenDummyIsDead()
        {
            Hero hero = new Hero("Barbarian",new FakeWapon());
            ITarget fakeTarget = new FakeTarget();

            while (!fakeTarget.IsDead())
            {
                hero.Attack(fakeTarget);
            }

            Assert.AreEqual(hero.Experience, FakeGiveExpirience);
        }
    }
}
