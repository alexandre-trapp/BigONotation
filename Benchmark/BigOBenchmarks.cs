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
    private readonly Common _common = new();

    [Benchmark(Description = "O(1)")]
    public void BigO_1()
    {
        var isEven = new BigO_1_IsEven().IsEven(9);
    }

    [Benchmark(Description = "O(log n)")]
    public void BigO_LogN()
    {
        new BigO_Log_N_BinarySearch().BinarySearch(_common.OrderedNumbers, 52);
    }

    [Benchmark(Description = "O(n)")]
    public void BigO_N()
    {
        new BigO_N_SimpleLoop().SimpleLoop(84);
    }

    [Benchmark(Description = "O(n log n)")]
    public void BigO_NLogN()
    {
        new BigO_NLogN_MergeSort().OrderingMergeSort();
    }

    [Benchmark(Description = "O(n^2)")]
    public void BigO_N2()
    {
        new BigO_N2_NestedLoop().NestedLoop();
    }

    [Benchmark(Description = "O(2^n)")]
    public void BigO_2N()
    {
        new BigO_2N_HanoiTower().TowerOfHanoi(13, 'A', 'B', 'C');
    }
}
