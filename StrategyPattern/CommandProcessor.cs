using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class CommandProcessor
    {
        private readonly IContainer container;

        public CommandProcessor(IContainer container)
        {
            this.container = container;
        }

        public void ProcessCommand(string command, string param)
        {
            container.ResolveNamed<ICommand>(command).Process(param);
        }
    }
}
