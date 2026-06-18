using SeanWelton.SortingAnalysis;

namespace SeanWelton.SortingAnalysis.Tests;

public class SortingAlgorithmTests
{
    [Theory]
    [MemberData(nameof(SortingAlgorithms))]
    public void Sorter_ShouldSortRandomArray(ISortingStrategy<int> sorter)
    {
        int[] data = [5, 3, 8, 1, 2, 9, 4, 7, 6];

        sorter.Sort(data);

        Assert.Equal([1, 2, 3, 4, 5, 6, 7, 8, 9], data);
    }

    [Theory]
    [MemberData(nameof(SortingAlgorithms))]
    public void Sorter_ShouldHandleSortedArray(ISortingStrategy<int> sorter)
    {
        int[] data = [1, 2, 3, 4, 5, 6, 7, 8, 9];

        sorter.Sort(data);

        Assert.Equal([1, 2, 3, 4, 5, 6, 7, 8, 9], data);
    }

    [Theory]
    [MemberData(nameof(SortingAlgorithms))]
    public void Sorter_ShouldHandleEmptyArray(ISortingStrategy<int> sorter)
    {
        int[] data = Array.Empty<int>();

        sorter.Sort(data);

        Assert.Empty(data);
    }

    [Theory]
    [MemberData(nameof(SortingAlgorithms))]
    public void Sorter_ShouldHandleSingleElement(ISortingStrategy<int> sorter)
    {
        int[] data = [42];

        sorter.Sort(data);

        Assert.Equal([42], data);
    }

    [Theory]
    [MemberData(nameof(SortingAlgorithms))]
    public void Sorter_ShouldHandleDuplicates(ISortingStrategy<int> sorter)
    {
        int[] data = [5, 2, 2, 7, 1, 2, 1, 9, 2];

        sorter.Sort(data);

        Assert.Equal([1, 1, 2, 2, 2, 2, 5, 7, 9], data);
    }

    public static IEnumerable<object[]> SortingAlgorithms()
    {
        yield return new object[] { new BubbleSort<int>() };
        yield return new object[] { new CocktailSort<int>() };
        yield return new object[] { new CombSort<int>() };
        yield return new object[] { new HeapSort<int>() };
        yield return new object[] { new InsertionSort<int>() };
        yield return new object[] { new MergeSort<int>() };
        yield return new object[] { new QuickSort<int>() };
        yield return new object[] { new SelectionSort<int>() };
        yield return new object[] { new ShellSort<int>() };
    }
}