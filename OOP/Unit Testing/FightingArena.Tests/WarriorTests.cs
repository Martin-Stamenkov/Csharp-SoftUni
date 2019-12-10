//using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void MethodShouldTestTheConstructor()
        {
            var name = "Pesho";
            var damage = 30;
            var hp = 20;

            Warrior warrior = new Warrior(name, damage, hp);

            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }

        [TestCase("", 10, 10)]
        [TestCase(null, 10, 10)]
        [TestCase("Pesho", 0, 10)]
        [TestCase("Pesho", -1, 10)]
        [TestCase("Pesho", -10, -1)]
        public void MethodShouldThrowArgumentExceptionifConstructorIsNotValid(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }
        [Test]
        public void MethodShouldThrowInvalidOperationExceptionWhenWarriorAttackWithHpBellow30()
        {
            var name = "Pesho";
            var damage = 30; 
            var hp = 20;

            Warrior warrior = new Warrior(name, damage, hp);

            Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("Gosho", 40, 50)));
        }
        [Test]
        public void MethodShouldThrowInvalidOperationExceptionWhenWarriorAttackEnemyWithHpBellow30()
        {
            var name = "Pesho";
            var damage = 30;
            var hp = 30;

            Warrior warrior = new Warrior(name, damage, hp);

            Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("Gosho", 20, 20)));
        }

        [TestCase("Gosho", 50, 100, "Pesho", 18, 49)]
        [TestCase("Gosho", 12, 100, "Pesho", 18, 30)]
        [TestCase("Gosho", 12, 100, "Pesho", 18, 20)]
        [TestCase("Gosho", 12, 30, "Pesho", 20, 55)]
        [TestCase("Gosho", 12, 11, "Pesho", 20, 55)]
        public void WarriorMethodAttackShouldThrowInvalidOperationExceptionIfYouTryToAttackStrongerEnemy
            (string firstWarrName, int firstWarrDamage, int firstWarrHP,
            string secondWarrName, int secondWarrDamage, int secondWarrHp)
        {
            var parameterWarr = new Warrior(firstWarrName, firstWarrDamage, firstWarrHP);
            var callerWarr = new Warrior(secondWarrName, secondWarrDamage, secondWarrHp);
            Assert.Throws<InvalidOperationException>(() => callerWarr.Attack(parameterWarr));
        }
        [Test]
        public void MethodShouldTestTheReduceOfHpWhenWarriorAttack()
        {
            Warrior warrior = new Warrior("Pesho", 30, 40);
            Warrior enemy = new Warrior("Gosho", 20, 40);

            warrior.Attack(enemy);

            var expectedHp = 20;
            var actualHp = warrior.HP;

            Assert.AreEqual(expectedHp, actualHp);
        }
        [Test]
        public void MethodShouldTestTheReduceHpOfAttackedWarrior()
        {
            Warrior warrior = new Warrior("Pesho", 30, 40);
            Warrior enemy = new Warrior("Gosho", 20, 40);

            warrior.Attack(enemy);

            var expectedHpEnemy = 10;
            var actualHpEnemy = enemy.HP;

            Assert.AreEqual(expectedHpEnemy, actualHpEnemy);

            warrior.Attack(enemy);

            var expectedHpEnemyAfterSecondAttack = 0;
            var actualHpEnemyAfterSecondAttack = enemy.HP;
            Assert.AreEqual(expectedHpEnemyAfterSecondAttack, actualHpEnemyAfterSecondAttack);
        }

    }
}