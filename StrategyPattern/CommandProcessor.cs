using Autofac;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class CommandProcessor: ICommandProcessor
    {
        private readonly Dictionary<string, CommandType> commands = new Dictionary<string, CommandType>()
        {
            {"search", CommandType.search},
            {"cs_search", CommandType.cs_search},
            {"create_txt", CommandType.create_txt},
            {"remove_txtrch", CommandType.remove_txt},
            {"exit", CommandType.exit},
        };
        private IContainer container;
        private readonly ILog log;

        public CommandProcessor(ILog log)
        {
            this.log = log;
        }

        public IContainer Container
        {
            get
            {
                return container;
            }
            set
            {
                container = value;
            }
        }

        public void ProcessCommand(string command, string param)
        {
            try
            {
                CommandType comm;
                if (!commands.TryGetValue(command, out comm))
                {
                    log.Debug(String.Format("'{0}' unknown command.", command));
                    Console.WriteLine("'{0}' unknown command.", command);
                    return;
                }
                container.ResolveKeyed<ICommand>(comm).Process(param);
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }
    }
}
