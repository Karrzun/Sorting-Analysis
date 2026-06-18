namespace SeanWelton.SortingAnalysis;

public class CocktailSort<T> : ISortingStrategy<T> where T : IComparable<T>
{
    public string Name => "Cocktail Sort";

    public void Sort(T[] data)
    {
        bool swapped = true;

        int start = 0;
        int end = data.Length - 1;

        while (swapped)
        {
            swapped = false;

            for (int i = start; i < end; i++)
            {
                if (data[i].CompareTo(data[i + 1]) > 0)
                {
                    (data[i], data[i + 1]) = (data[i + 1], data[i]);
                    swapped = true;
                }
            }

            if (!swapped)
                break;

            swapped = false;
            end--;

            for (int i = end - 1; i >= start; i--)
            {
                if (data[i].CompareTo(data[i + 1]) > 0)
                {
                    (data[i], data[i + 1]) = (data[i + 1], data[i]);
                    swapped = true;
                }
            }

            start++;
        }
    }
}