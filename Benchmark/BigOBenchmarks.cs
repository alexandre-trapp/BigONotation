using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using BigONotation.BigO;

namespace BigONotation.Benchmark;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
[MarkdownExporter]
public class BigOBenchmarks
{
    public readonly List<int> OrderedNumbers = new()
    {
        1, 2, 4, 6, 10, 14, 15, 19, 20, 34, 36, 38, 40, 42, 50, 52, 55, 60, 61, 62, 63, 67, 70, 78, 80, 82, 84, 86, 88, 90, 92, 93, 99, 101, 105, 107, 110, 115,118
    };

    public readonly List<int> UnorderedNumbers = new()
    {
        2, 23, -575, 1, -400, 8, 44, -90, 0, 4, 180, -32, 323, 73, 59, 663, 35, 45, -67, 28, 3, 5, -5, 52, 7, 62, -20, 9, 92, 63, -342, 12, 53, 200, 234, 756, 456
    };

    [Benchmark(Description = "O(1)")]
    public void BigO_1()
    {
        var isEven = BigO_1_IsEven.IsEven(9);
    }

    [Benchmark(Description = "O(log n)")]
    public void BigO_LogN()
    {
        BigO_Log_N_BinarySearch.BinarySearch(OrderedNumbers, 52);
    }

    [Benchmark(Description = "O(n)")]
    public void BigO_N()
    {
        BigO_N_SimpleLoop.SimpleLoop(84);
    }

    [Benchmark(Description = "O(n log n)")]
    public void BigO_NLogN()
    {
        BigO_NLogN_MergeSort.OrderingMergeSort();
    }

    [Benchmark(Description = "O(n^2)")]
    public void BigO_N2()
    {
        BigO_N2_NestedLoop.NestedLoop();
    }

    [Benchmark(Description = "O(2^n)")]
    public void BigO_2N()
    {
        BigO_2N_HanoiTower.TowerOfHanoi(13, 'A', 'B', 'C');
    }
}
