namespace SeanWelton.SortingAnalysis;

public class InsertionSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    public string Name => "Insertion Sort";

    public void Sort(T[] data)
    {
        for (int i = 1; i < data.Length; i++)
        {
            T key = data[i];

            int j = i - 1;

            while (j >= 0 && data[j].CompareTo(key) > 0)
            {
                data[j + 1] = data[j];
                j--;
            }

            data[j + 1] = key;
        }
    }
}