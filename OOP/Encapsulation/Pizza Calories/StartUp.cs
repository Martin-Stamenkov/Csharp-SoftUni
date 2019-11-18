using System;

namespace Pizza_Calories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var pizzaName = Console.ReadLine()
              .Split(" ")[1];

                var input = Console.ReadLine()
                   .Split(" ");

                var flourType = input[1];
                var bakingTehnique = input[2];
                var weight = double.Parse(input[3]);

                Dough dough = new Dough(flourType, bakingTehnique, weight);
                Pizza pizza = new Pizza(pizzaName, dough);

                var command = Console.ReadLine();

                while (command != "END")
                {
                    var toppinginput = command
                     .Split(" ");

                    var toppingName = toppinginput[1];
                    var weightTopping = double.Parse(toppinginput[2]);

                    Topping topping = new Topping(toppingName, weightTopping);
                    pizza.AddToping(topping);

                    command = Console.ReadLine();
                }
                Console.WriteLine($"{pizzaName} - {pizza.SumTotalCaloriesOfPizza():f2} Calories.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
