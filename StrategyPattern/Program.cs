using Autofac;
using System;

namespace StrategyPattern
{
    class Program
    {
        static IContainer container = GetContainer();

        static void Main()
        {
            do
            {
                Console.Write("enter command and parameter: ");
                string input = Console.ReadLine();
                var args = GetArguments(input);
                string command = args.Item1;
                string param = args.Item2;

                CommandProcessor commandProcessor = new CommandProcessor(container);
                commandProcessor.ProcessCommand(command, param);
            } while (true);
        }

        private static Tuple<string, string> GetArguments(string input)
        {
            string[] result = input.Split(' ');
            string arg1 = result.Length > 0 ? result[0] : null;
            string arg2 = result.Length > 1 ? result[1] : null;
            return Tuple.Create(arg1, arg2);
        }

        static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SearchCommand>().Keyed<ICommand>(CommandType.search);
            builder.RegisterType<CsSearchCommand>().Keyed<ICommand>(CommandType.cs_search);
            builder.RegisterType<CreateTxtCommand>().Keyed<ICommand>(CommandType.create_txt);
            builder.RegisterType<RemoveTxtCommand>().Keyed<ICommand>(CommandType.remove_txt);
            builder.RegisterType<ExitCommand>().Keyed<ICommand>(CommandType.exit);
            return builder.Build();
        }
    }
}
