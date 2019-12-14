using System;

namespace MXGP
{
    using Models.Motorcycles;
    using MXGP.Core;
    using MXGP.Core.Contracts;
    using MXGP.IO;
    using MXGP.IO.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ////TODO Add IEngine
            //Motorcycle varche = new PowerMotorcycle("12214235", 75);
            //Console.WriteLine(varche.HorsePower);
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            ChampionshipController championshipController = new ChampionshipController();
            IEngine engine = new Engine(championshipController, writer, reader);
            engine.Run();
                
        }
    }
}
