namespace SeanWelton.SortingAnalysis;

public class SelectionSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    public string Name => "Selection Sort";

    public void Sort(T[] data)
    {
        for (int i = 0; i < data.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < data.Length; j++)
            {
                if (data[j].CompareTo(data[minIndex]) < 0)
                    minIndex = j;
            }

            if (minIndex != i)
                (data[i], data[minIndex]) = (data[minIndex], data[i]);
        }
    }
}