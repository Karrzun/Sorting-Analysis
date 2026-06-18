namespace SeanWelton.SortingAnalysis;

public class HeapSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    public string Name => "Heap Sort";

    public void Sort(T[] data)
    {
        int n = data.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(data, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            (data[0], data[i]) = (data[i], data[0]);
            Heapify(data, i, 0);
        }
    }

    private void Heapify(T[] data, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && data[left].CompareTo(data[largest]) > 0)
            largest = left;

        if (right < n && data[right].CompareTo(data[largest]) > 0)
            largest = right;

        if (largest != i)
        {
            (data[i], data[largest]) = (data[largest], data[i]);
            Heapify(data, n, largest);
        }
    }
}