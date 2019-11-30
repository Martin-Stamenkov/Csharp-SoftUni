using NUnit.Framework;
using System;

namespace Tests
{
     using Database;

    public class DatabaseTests
    {
        [Test]
        public void CounstructorShouldInitalize16theenElements()
        {
            Database database = new Database(new int [16]);

            int expectedResult = 16;
            int actualResult = database.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void CounstructorShouldThrowInalidOperationExceptionIfIsNot16theenElements()
        {
            int[] array = new int[17];
            Assert.Throws<InvalidOperationException>(()=> new Database(array));
        }
        [Test]
        public void MethodCantAddMoreThan16theenElements()
        {
            Database database = new Database(new int [16]);

            Assert.Throws<InvalidOperationException>(() => database.Add(10));
        }
        [Test]
        public void MethodMustIncreaseTheCountOfArray()
        {
            Database database = new Database();

            database.Add(1);

            int expectedResult = 1;
            int actualResult = database.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void MethodMustAddElementToTheNexCell()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            Database database = new Database(array);

            database.Add(7);
            int expectedResult = 7;
            int actualResult = database.Fetch()[6];

            Assert.AreEqual(expectedResult, actualResult);
         
        }
        [Test]
        public void MethodShouldRemoveLastElementOfTheArray()
        {
            int[] array = { 1, 2, 3 };
        
            Database database = new Database(array);
            database.Remove();

            int expectedValue = 2;
            int actualValue = database.Fetch()[database.Count-1];

            Assert.AreEqual(expectedValue, actualValue);
               
        }
        [Test]
        public void MethodCantRemoveFromEmptyArray()
        {
            Database database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
       [Test]
       public void FetchMethodMustReturnAllElementsAsArray()
       {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            Database database = new Database(array);

            int[] exceptedArray = database.Fetch();
            int[] actualArray = array;

            CollectionAssert.AreEqual(exceptedArray, actualArray);
       }
    }
}