namespace SeanWelton.SortingAnalysis;

public class QuickSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    public string Name => "Quick Sort";

    public void Sort(T[] data)
    {
        QuickSortRecursive(data, 0, data.Length - 1);
    }

    private void QuickSortRecursive(T[] data, int low, int high)
    {
        if (low >= high)
            return;

        int pivotIndex = Partition(data, low, high);

        QuickSortRecursive(data, low, pivotIndex - 1);
        QuickSortRecursive(data, pivotIndex + 1, high);
    }

    private int Partition(T[] data, int low, int high)
    {
        T pivot = data[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (data[j].CompareTo(pivot) <= 0)
            {
                i++;
                (data[i], data[j]) = (data[j], data[i]);
            }
        }

        (data[i + 1], data[high]) = (data[high], data[i + 1]);
        return i + 1;
    }
}