namespace SeanWelton.SortingAnalysis;

public class MergeSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    public string Name => "Merge Sort";

    public void Sort(T[] data)
    {
        if (data.Length <= 1)
            return;

        T[] tmp = new T[data.Length];
        MergeSortRecursive(data, tmp, 0, data.Length - 1);
    }

    private void MergeSortRecursive(T[] data, T[] tmp, int left, int right)
    {
        if (left >= right)
            return;

        int mid = (left + right) / 2;

        MergeSortRecursive(data, tmp, left, mid);
        MergeSortRecursive(data, tmp, mid + 1, right);

        Merge(data, tmp, left, mid, right);
    }

    private void Merge(T[] data, T[] tmp, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (data[i].CompareTo(data[j]) <= 0)
                tmp[k++] = data[i++];
            else
                tmp[k++] = data[j++];
        }

        while (i <= mid)
            tmp[k++] = data[i++];

        while (j <= right)
            tmp[k++] = data[j++];

        for (int x = left; x <= right; x++)
            data[x] = tmp[x];
    }
}