using System.Diagnostics;

namespace SeanWelton.SortingAnalysis;

public class BenchmarkRunner<T> where T : IComparable<T>
{
    public BenchmarkResult Run(ISortingStrategy<T> strategy, IDataGenerator<T> generator, int size)
    {
        T[] data = generator.Generate(size);

        T[] workingCopy = new T[data.Length];
        Array.Copy(data, workingCopy, size);

        var stopwatch = Stopwatch.StartNew();
        strategy.Sort(workingCopy);
        stopwatch.Stop();

        return new BenchmarkResult
        {
            AlgorithmName = strategy.Name,
            DatasetName = generator.Name,
            DataSize = size,
            ElapsedMilliseconds = stopwatch.ElapsedMilliseconds,
        };
    }
}