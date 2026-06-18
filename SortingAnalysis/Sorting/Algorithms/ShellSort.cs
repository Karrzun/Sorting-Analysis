namespace SeanWelton.SortingAnalysis;

public class ShellSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    public string Name => "Shell Sort";

    public void Sort(T[] data)
    {
        int n = data.Length;

        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                T tmp = data[i];

                int j;

                for (j = i; j >= gap && data[j - gap].CompareTo(tmp) > 0; j -= gap)
                {
                    data[j] = data[j - gap];
                }

                data[j] = tmp;
            }
        }
    }
}