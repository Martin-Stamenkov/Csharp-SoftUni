using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
     public class StartUp
    {
       public static void Main(string[] args)
        {
     

            var personInfoOutput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstAndLastName = personInfoOutput[0] + " " + personInfoOutput[1];
            var street = personInfoOutput[2];
            var town = personInfoOutput[3] + " " + personInfoOutput[4];

            var personBeerOutput = Console.ReadLine().Split();

            var name = personBeerOutput[0];
            var litters = int.Parse(personBeerOutput[1]);
            var isDrunk = personBeerOutput[2];

            var numbersInfoOutput = Console.ReadLine().Split();

            var firstName = (numbersInfoOutput[0]);
            var @double = double.Parse(numbersInfoOutput[1]);
            var bankName = numbersInfoOutput[2];

            var personInfo = new Threeuple<string, string, string>(firstAndLastName, street,town);

            var personBeer = new Threeuple<string, int,string>(name,litters,isDrunk);

            var numbersInfo = new Threeuple<string, double,string>(firstName,@double,bankName);

            Console.WriteLine(personInfo);
            Console.WriteLine(personBeer);
            Console.WriteLine(numbersInfo);

        }
      
    }

}
