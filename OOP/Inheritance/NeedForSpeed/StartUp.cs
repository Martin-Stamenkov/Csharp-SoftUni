using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var hp = int.Parse(Console.ReadLine());

            var fuel = double.Parse(Console.ReadLine());

            Vehicle vehicle = new Car(hp, fuel);
            vehicle.Drive(20);

            Console.WriteLine(vehicle);
            
        }
    }
}
