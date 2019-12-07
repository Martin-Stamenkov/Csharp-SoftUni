namespace Tests
{
    using NUnit.Framework;
    using ExtendedDatabase;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private const string Username = "Gosho";  
        private const long Id = 9104091563;

        private Person person;
        private ExtendedDatabase extendedDatabase;
        [SetUp]
        public void TestInit()
        {
            person = new Person(9104091563, "Gosho");
            extendedDatabase = new ExtendedDatabase();
        }
        [Test]
        public void MethodShouldTestTheConstructor()
        {
            Assert.AreEqual(person.Id,Id);
            Assert.AreEqual(person.UserName,Username);
        }
        [Test]
        public void MethodShouldAddValidPerson()
        {
            extendedDatabase.Add(person);

            Person person2 = new Person(7112200562, "Petko");
            extendedDatabase.Add(person2);

            Assert.AreEqual(person2, extendedDatabase.FindByUsername("Petko"));
        }
        [Test]
        public void MethodShouldThrowInvalidOperationExceptionIfNameAlreadyExist()
        {
            extendedDatabase.Add(person);

            Assert.AreEqual(Username, person.UserName);
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(person));
        }
        [Test]
        public void MethodMustIncreaseTheCountOfCollection()
        {
            extendedDatabase.Add(person);

            int expectedResult = 1;
            int actualResult = extendedDatabase.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void MethodCantRemovePersonFromEmptyStore()
        {
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Remove());
        }
        [Test]
        public void MethodShouldRemoveLastPersonOfCollection()
        {
            Person person2 = new Person(9205091565,"Pesho");

            extendedDatabase.Add(person);
            extendedDatabase.Add(person2);
            extendedDatabase.Remove();

            var expectedValue = person;
            var actualValue = extendedDatabase.FindByUsername("Gosho");

            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void MethodShouldThrowInvalidOperationExceptionIfNameDoesntExist()
        {
            extendedDatabase.Add(person);

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindByUsername("Stancho"));
        }
        [Test]
        public void MethodMustFindPersonByUserName()
        {
            extendedDatabase.Add(person);

            var expectedResult = person;
            var actualResult = extendedDatabase.FindByUsername("Gosho");

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void MethodShouldThrowArgumentNullExceptionIfNameIsNull()
        {
            extendedDatabase.Add(person);

            Assert.Throws<ArgumentNullException>(() => extendedDatabase.FindByUsername(null));
        }
        [Test]
        public void MethodShouldThrowInvalidOperationExceptionIfArgumentsAreAllCaseSensitive()
        {
            extendedDatabase.Add(person);

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindByUsername("GOSHO"));
        }
        [Test]
        public void MethodShouldThrowInvalidOperationExceptionIfIdDoesntExist()
        {
            extendedDatabase.Add(person);

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindById(9134596563));
        }
        [Test]
        public void MethodShouldThrowArgumentOutOfRangeExceptionIfIdIsNegative()
        {
            extendedDatabase.Add(person);

            Assert.Throws<ArgumentOutOfRangeException>(() => extendedDatabase.FindById(-9134596563));
        }
        [Test]
        public void MethodMustFindPersonById()
        {
            extendedDatabase.Add(person);

            var expectedResult = person.Id;
            var actualResult = Id;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}