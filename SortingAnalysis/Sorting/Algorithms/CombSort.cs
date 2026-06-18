namespace SeanWelton.SortingAnalysis;

public class CombSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    public string Name => "Comb Sort";

    public void Sort(T[] data)
    {
        int gap = data.Length;

        bool swapped = true;

        while (gap > 1 || swapped)
        {
            gap = (int)(gap / 1.3);
            
            if (gap < 1)
                gap = 1;

            swapped = false;

            for (int i = 0; i + gap < data.Length; i++)
            {
                if (data[i].CompareTo(data[i + gap]) > 0)
                {
                    (data[i], data[i + gap]) = (data[i + gap], data[i]);
                    swapped = true;
                }
            }
        }
    }
}