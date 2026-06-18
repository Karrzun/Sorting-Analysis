namespace SeanWelton.SortingAnalysis;

public class NearlySortedIntGenerator : IDataGenerator<int>
{
    private readonly Random random = new Random();

    public string Name => "Nearly Sorted";

    public int[] Generate(int size)
    {
        var data = new int[size];

        for (int i = 0; i < size; i++)
            data[i] = i;

        for (int i = 0; i < size / 10; i++)
        {
            int a = random.Next(size);
            int b = random.Next(size);

            (data[a], data[b]) = (data[b], data[a]);
        }

        return data;
    }
}