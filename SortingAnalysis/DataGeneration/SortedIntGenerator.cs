namespace SeanWelton.SortingAnalysis;

public class SortedIntGenerator : IDataGenerator<int>
{
    public string Name => "Sorted";

    public int[] Generate(int size)
    {
        var data = new int[size];

        for (int i = 0; i < size; i++)
            data[i] = i;

        return data;
    }
}