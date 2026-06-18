namespace SeanWelton.SortingAnalysis;

public class RandomIntGenerator : IDataGenerator<int>
{
    private readonly Random random = new();

    public string Name => "Random";

    public int[] Generate(int size)
    {
        var data = new int[size];

        for (int i = 0; i < size; i++)
            data[i] = random.Next(0, size);

        return data;
    }
}