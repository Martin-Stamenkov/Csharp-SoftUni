using Collection_Hierarchy.Contracts;
using Collection_Hierarchy.Models;
using System;
using System.Collections.Generic;

namespace Collection_Hierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IAddCollection<string> addCollection = new AddCollection<string>();
            IAddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
            IMyList<string> myList = new MyList<string>();

            var elements = Console.ReadLine()
                .Split(" ");

            var removeOperations = int.Parse(Console.ReadLine());

            AddMethod(addCollection,elements);

            AddMethod(addRemoveCollection,elements);

            AddMethod(myList, elements);

            RemoveMethod(addRemoveCollection,removeOperations);

            RemoveMethod(myList,removeOperations);

        }

        private static void RemoveMethod(IAddRemoveCollection<string> addRemoveCollection, int removeOperations)
        {
            var removeResult = new List<string>();

            for (int i = 0; i < removeOperations; i++)
            {
                removeResult.Add(addRemoveCollection.Remove());
            }

            Console.WriteLine(string.Join(" ", removeResult));
        }

        public static void AddMethod(IAddCollection<string> collection, string[] strings)
        {
            var addResult = new List<int>();

            foreach (var item in strings)
            {
                addResult.Add(collection.Add(item));
            }

            Console.WriteLine(string.Join(" ", addResult));
        }
    }
}