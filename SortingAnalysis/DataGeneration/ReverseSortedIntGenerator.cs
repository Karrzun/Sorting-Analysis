namespace SeanWelton.SortingAnalysis;

public class ReverseSortedIntGenerator : IDataGenerator<int>
{
    public string Name => "Reverse Sorted";

    public int[] Generate(int size)
    {
        var data = new int[size];

        for (int i = 0; i < size; i++)
            data[i] = size - i;

        return data;
    }
}