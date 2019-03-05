using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = args[0];
            string param = args[1];

            IContainer container = GetContainer();
            CommandProcessor commandProcessor = new CommandProcessor(container);
            commandProcessor.ProcessCommand(command, param);

            Console.ReadLine();
        }

        static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SearchCommand>().Named<ICommand>("search");
            builder.RegisterType<CsSearchCommand>().Named<ICommand>("cs_search");
            builder.RegisterType<CreateTxtCommand>().Named<ICommand>("create_txt");
            builder.RegisterType<RemoveTxtCommand>().Named<ICommand>("remove_txt");
            return builder.Build();
        }
    }
}
