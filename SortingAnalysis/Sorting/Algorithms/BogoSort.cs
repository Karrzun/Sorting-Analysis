namespace SeanWelton.SortingAnalysis;

public class BogoSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    private readonly Random random = new();

    public string Name => "Bogo Sort";

    public void Sort(T[] data)
    {
        while (IsSorted(data))
            Shuffle(data);
    }

    private bool IsSorted(T[] data)
    {
        for (int i = 1; i < data.Length; i++)
        {
            if (data[i - 1].CompareTo(data[i]) > 0)
                return false;
        }
        return true;
    }

    private void Shuffle(T[] data)
    {
        for (int i = data.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (data[i], data[j]) = (data[j], data[i]);
        }
    }
}