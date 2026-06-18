namespace SeanWelton.SortingAnalysis;

public class BenchmarkSuite<T> where T : IComparable<T>
{
    private readonly HashSet<ISortingStrategy<T>> strategies = new();
    private readonly HashSet<IDataGenerator<T>> generators = new();

    public void AddStrategy(ISortingStrategy<T> strategy) => strategies.Add(strategy);

    public void AddGenerator(IDataGenerator<T> generator) => generators.Add(generator);

    public List<BenchmarkResult> RunAll(int size)
    {
        var results = new List<BenchmarkResult>();
        var runner = new BenchmarkRunner<T>();

        foreach (var strategy in strategies)
        {
            foreach (var generator in generators)
            {
                var result = runner.Run(strategy, generator, size);
                results.Add(result);
            }
        }

        return results;
    }
}