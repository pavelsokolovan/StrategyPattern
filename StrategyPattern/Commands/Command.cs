using System.IO;

namespace StrategyPattern
{
    abstract class Command : ICommand
    {
        private readonly ILog log;

        public Command(ILog log)
        {
            this.log = log;
        }

        public abstract void Process(string param);

        public bool IsDirctoryExist(string path)
        {
            return Directory.Exists(path);
        }

        protected ILog Log
        {
            get
            {
                return log;
            }
        }
    }
}