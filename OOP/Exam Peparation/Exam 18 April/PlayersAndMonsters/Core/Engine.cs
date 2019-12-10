using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writter;
        private readonly IManagerController managerController;

        public Engine(IReader iReader, IWriter iWritter, IManagerController managerController)
        {
            this.reader = iReader;
            this.writter = iWritter;
            this.managerController = managerController;
        }

        public void Run()
        {  
            while (true)
            {
                var input = reader.ReadLine().Split();

                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }

                try
                {
                    if (input[0] == "AddPlayer")
                    {
                        writter.WriteLine(managerController.AddPlayer(input[1], input[2]));
                    }
                    else if (input[0] == "AddCard")
                    {
                        writter.WriteLine(managerController.AddCard(input[1], input[2]));
                    }
                    else if (input[0] == "AddPlayerCard")
                    {
                        writter.WriteLine(managerController.AddPlayerCard(input[1], input[2]));
                    }
                    else if (input[0] == "Fight")
                    {
                        writter.WriteLine(managerController.Fight(input[1], input[2]));
                    }
                    else if (input[0] == "Report")
                    {
                        writter.WriteLine(managerController.Report());
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
