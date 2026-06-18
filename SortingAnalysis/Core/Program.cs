namespace SeanWelton.SortingAnalysis;

internal class Program
{
    static void Main(string[] args)
    {
        var suite = new BenchmarkSuite<int>();

        suite.AddStrategy(new BubbleSort<int>());
        suite.AddStrategy(new CocktailSort<int>());
        suite.AddStrategy(new CombSort<int>());
        suite.AddStrategy(new HeapSort<int>());
        suite.AddStrategy(new InsertionSort<int>());
        suite.AddStrategy(new MergeSort<int>());
        suite.AddStrategy(new QuickSort<int>());
        suite.AddStrategy(new SelectionSort<int>());
        suite.AddStrategy(new ShellSort<int>());

        suite.AddGenerator(new RandomIntGenerator());
        suite.AddGenerator(new SortedIntGenerator());
        suite.AddGenerator(new ReverseSortedIntGenerator());
        suite.AddGenerator(new NearlySortedIntGenerator());

        var results = suite.RunAll(10000);

        Console.WriteLine("===== Benchmark Result =====");

        foreach (var result in results)
        {
            Console.WriteLine($"{result.AlgorithmName.PadRight(15)}\t{result.DatasetName.PadRight(20)}\t{result.DataSize.ToString().PadRight(10)}\t{result.ElapsedMilliseconds} ms");
        }
    }
}
