using Collection_Hierarchy.Contracts;
using Collection_Hierarchy.Models;
using System;

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
            
        }
    }
}