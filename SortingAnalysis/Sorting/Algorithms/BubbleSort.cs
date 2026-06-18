namespace SeanWelton.SortingAnalysis;

public class BubbleSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    public string Name => "Bubble Sort";

    public void Sort(T[] data)
    {
        int n = data.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (data[j].CompareTo(data[j + 1]) > 0)
                {
                    (data[j], data[j + 1]) = (data[j + 1], data[j]);
                }
            }
        }
    }
}