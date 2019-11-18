using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var peopleList = new List<Person>();
                var productList = new List<Product>();

                var people = Console.ReadLine().Split(";");
                for (int i = 0; i < people.Length; i++)
                {
                    var splitPerson = people[i].Split("=");
                    Person person = new Person(splitPerson[0], int.Parse(splitPerson[1]));
                    peopleList.Add(person);
                }

                var products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < products.Length; i++)
                {
                    var splitPRoduct = products[i].Split("=");

                    var nameProduct = splitPRoduct[0];
                    var cost = int.Parse(splitPRoduct[1]);

                    Product product = new Product(nameProduct, cost);
                    productList.Add(product);

                }

                var command = Console.ReadLine();

                while (command != "END")
                {
                    var info = command.Split(" ");
                    var name = info[0];
                    var product = info[1];

                    Person person = peopleList.FirstOrDefault(p => p.Name == name);
                    Product boughtProduct = productList.FirstOrDefault(b => b.Name == product);

                    person.AddToBag(boughtProduct);

                    command = Console.ReadLine();
                }

                foreach (var person in peopleList)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
