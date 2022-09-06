using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace BigONotation.Benchmark;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
[MarkdownExporter]
public class BigOBenchmarks
{
    readonly List<int> OrderedNumbers = new()
        {
            1, 2, 4, 6, 10, 14, 15, 19, 20, 34, 36, 38, 40, 42, 50, 52, 55, 60, 61, 62, 63, 67, 70, 78, 80, 82, 84, 86, 88, 90, 92, 93, 99, 101, 105, 107, 110, 115,118
        };

    readonly List<int> UnorderedNumbers = new()
        {
            2, 23, -575, 1, -400, 8, 44, -90, 0, 4, 180, -32, 323, 73, 59, 663, 35, 45, -67, 28, 3, 5, -5, 52, 7, 62, -20, 9, 92, 63, -342, 12, 53, 200, 234, 756, 456
        };
}
