using Autofac;

namespace StrategyPattern
{
    interface ICommandProcessor
    {
        IContainer Container { get; set; }
        void ProcessCommand(string command, string param);
    }
}
