using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ContainerResolver : IContainerResolver
    {
        private IContainer container;

        public ContainerResolver(IContainer container)
        {
            this.container = container;
        }

        public T Resolve<T>(string name)
        {
            return container.ResolveNamed<T>(name);
        }
    }
}
