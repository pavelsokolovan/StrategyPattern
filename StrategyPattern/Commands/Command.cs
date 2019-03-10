using System.IO;

namespace StrategyPattern
{
    abstract class Command : ICommand
    {
        public abstract void Process(string param);

        public bool IsDirctoryExist(string path)
        {
            return Directory.Exists(path);
        }
    }
}