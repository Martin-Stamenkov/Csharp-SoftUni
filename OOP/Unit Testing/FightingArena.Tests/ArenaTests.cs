//using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MethodShouldTestEnrollCorrectly()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Pesho", 20, 40);
            arena.Enroll(warrior);

            var expectedValue = warrior;
            var actualValue = new Warrior("Pesho", 20, 40);

            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void MethodShouldIncreaseTheCountWhenWarriorIsEnrolled()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Pesho", 20, 40);
            arena.Enroll(warrior);

            Assert.AreEqual(1, arena.Warriors.Count);
            Assert.AreEqual(1, arena.Count);
        }
        [Test]
        public void MethodShouldThrowInvalidOperationExceptionifWarriorAlreadyExist()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Pesho", 20, 40);
            Warrior warrior2 = new Warrior("Pesho", 30, 50);
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior2));
        }
        [TestCase("Ivan","Pesho")]
        [TestCase("Gosho","Ivan")]
        public void MethodShouldThrowInvalidOperationExceptionifOneOfTheWarriorsIsNotEnroled(string attacker , string deffender)
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Pesho", 20, 40);
            Warrior warrior2 = new Warrior("Gosho", 30, 50);
            arena.Enroll(warrior);
            arena.Enroll(warrior2);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker,deffender));
            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker,deffender));
        }
        [Test]
        public void MethodShouldTestTheFight()
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior("Pesho", 25, 50);
            Warrior defender = new Warrior("Gosho", 15, 50);
            arena.Enroll(attacker);
            arena.Enroll(defender);
            arena.Fight(attacker.Name, defender.Name);

            var expectedValueDef = 25;
            var actualValueDef = defender.HP;
            var expectedValueAttacker = 35;
            var actualValueAttacker = attacker.HP;

            Assert.AreEqual(expectedValueDef, actualValueDef);
            Assert.AreEqual(expectedValueAttacker, actualValueAttacker);
        }
    }
}
