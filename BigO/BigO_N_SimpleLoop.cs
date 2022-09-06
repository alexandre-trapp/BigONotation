using BigONotation.Benchmark;

namespace BigONotation.BigO;

public static class BigO_N_SimpleLoop
{
    public static bool SimpleLoop(int searchedNumber)
    {
        // O(n)
        foreach (var element in BigOBenchmarks.OrderedNumbers)
        {
            if (element == searchedNumber)
                return true;
        }

        return false;
    }
}
