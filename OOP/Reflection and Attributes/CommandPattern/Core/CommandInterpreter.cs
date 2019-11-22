using CommandPattern.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{ 
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputArgs = args.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string[] commandArgs = inputArgs.Skip(1).ToArray();

            string commandName = (inputArgs[0] + "Command").ToLower();

            var commandType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x=>x.Name.ToLower() == commandName);

            if (commandType == null)
            {
                throw new Exception("Invalid command type!");
            }

            var instance = Activator.CreateInstance(commandType) as ICommand;

            if (instance == null)
            {
                throw new Exception("Invalid instance!");
            }

            string result = instance.Execute(commandArgs);

            return result;
        }
    }
}
