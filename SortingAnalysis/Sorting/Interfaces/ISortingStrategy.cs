namespace SeanWelton.SortingAnalysis;

public interface ISortingStrategy<T> where T :IComparable<T>
{
    string Name { get; }

    void Sort(T[] data);
}