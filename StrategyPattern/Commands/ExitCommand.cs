using System;

namespace StrategyPattern
{
    internal class ExitCommand : ICommand
    {
        public void Process(string param)
        {
            Console.WriteLine("bye");
            Environment.Exit(0);
        }
    }
}