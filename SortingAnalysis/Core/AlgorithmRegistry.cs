namespace SeanWelton.SortingAnalysis;

public class AlgorhtmRegistry<T> where T : IComparable<T>
{
    private readonly Dictionary<string, ISortingStrategy<T>> strategies = new();

    public void Register(string name, ISortingStrategy<T> strategy)
    {
        strategies[name.ToLower()] = strategy;
    }

    public ISortingStrategy<T> Get(string name)
    {
        if (strategies.TryGetValue(name.ToLower(), out var strategy))
            return strategy;

        throw new ArgumentException($"Algorithm '{name}' not found.");
    }

    public IEnumerable<string> GetAvailableAlgorithms() => strategies.Keys;
}