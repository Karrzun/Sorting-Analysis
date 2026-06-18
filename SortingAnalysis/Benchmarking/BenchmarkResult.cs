namespace SeanWelton.SortingAnalysis;

public class BenchmarkResult
{
    public string AlgorithmName { get; set; } = "";
    public string DatasetName { get; set; } = "";

    public int DataSize { get; set; }

    public long ElapsedMilliseconds { get; set; }
}