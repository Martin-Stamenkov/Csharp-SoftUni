using System;

namespace Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var driversName = Console.ReadLine();

            var model = "488-Spider";

            Ferrari ferrari = new Ferrari(model,driversName);

            Console.WriteLine(ferrari);
        }
    }
}
