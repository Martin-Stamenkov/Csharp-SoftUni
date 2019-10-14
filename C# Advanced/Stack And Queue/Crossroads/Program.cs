using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int yellowLight = int.Parse(Console.ReadLine());

            int green = greenLight;
            int yellow = yellowLight;

            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();

            int count = 0;

            while (command != "END")
            {

                if (command == "green")
                {
                    while (greenLight > 0 && cars.Any())
                    {
                        string eachCar = cars.Peek();
                        if (eachCar.Length <= greenLight)
                        {
                            greenLight -= eachCar.Length;
                            cars.Dequeue();
                            count++;
                        }
                        else
                        {
                            if ((greenLight + yellowLight) >= eachCar.Length)
                            {
                                for (int i = 0; i < eachCar.Length; i++)
                                {
                                    greenLight -= 1;
                                   eachCar = eachCar.Remove(0,1);
                                    if (greenLight==0)
                                    {
                                        for (int j = 0; j < eachCar.Length; j++)
                                        {
                                            yellowLight -= 1;
                                            eachCar = eachCar.Remove(0, 1);
                                        }
                                    }
                                }
                                cars.Dequeue();
                                count++;
                            }
                            else
                            {
                                int freeWindow = greenLight + yellowLight;
                                eachCar = eachCar.Remove(0, freeWindow);
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{cars.Peek()} was hit at {eachCar[0]}.");
                                return;
                            }
                        }
                    }
                    greenLight = green;
                    yellowLight = yellow;
                }
                else
                {
                    cars.Enqueue(command);
                }
                

                command = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
