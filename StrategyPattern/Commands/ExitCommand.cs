using System;

namespace StrategyPattern
{
    internal class ExitCommand: Command, ICommand
    {
        public ExitCommand(ILog log) : base(log)
        {
        }

        public override void Process(string param)
        {
            Console.WriteLine("bye");
            Environment.Exit(0);
        }
    }
}