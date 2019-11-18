using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Huawei");

            var numbers = Console.ReadLine()
                 .Split(" ").ToArray();

            var sites = Console.ReadLine()
                .Split(" ").ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine(smartphone.Number(number));
            }

            foreach (var site in sites)
            {
                Console.WriteLine(smartphone.Site(site));
            }
        }
    }
}
