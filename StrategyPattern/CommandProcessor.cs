using Autofac;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class CommandProcessor
    {
        private readonly Dictionary<string, CommandType> commands = new Dictionary<string, CommandType>()
        {
            {"search", CommandType.search},
            {"cs_search", CommandType.cs_search},
            {"create_txt", CommandType.create_txt},
            {"remove_txtrch", CommandType.remove_txt},
            {"exit", CommandType.exit},
        };
        private readonly IContainer container;

        public CommandProcessor(IContainer container)
        {
            this.container = container;
        }

        public void ProcessCommand(string command, string param)
        {
            try
            {
                CommandType comm;
                if (!commands.TryGetValue(command, out comm))
                {
                    Console.WriteLine("unknown command");
                    return;
                }
                container.ResolveKeyed<ICommand>(comm).Process(param);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
