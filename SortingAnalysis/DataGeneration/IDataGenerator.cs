namespace SeanWelton.SortingAnalysis;

public interface IDataGenerator<T>
{
    string Name { get; }

    T[] Generate(int size);
}