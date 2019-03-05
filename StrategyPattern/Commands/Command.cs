namespace StrategyPattern
{
    abstract class Command : ICommand
    {
        public abstract void Process(string param);
    }
}