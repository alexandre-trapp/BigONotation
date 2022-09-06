using BigONotation.Benchmark;

namespace BigONotation.BigO;

public static class BigO_N2_NestedLoop
{
    public static void NestedLoop()
    {
        var n2Array = new int[20000];

        int counter = 0;

        // O(n * n) = O(n²)

        for (int i = 0; i < n2Array.Length; i++)         // O(n)
        {
            for (int j = 0; j < n2Array.Length; j++)     // O(n)
            {
                counter++;
            }
        }

        Console.WriteLine("O(n^2) finished in " + counter.ToString() + " cycles.");
    }
}
