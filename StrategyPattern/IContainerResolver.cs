namespace StrategyPattern
{
    internal interface IContainerResolver
    {
        T Resolve<T>(string name);
    }
}