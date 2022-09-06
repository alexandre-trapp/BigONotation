using BigONotation.Benchmark;

namespace BigONotation.BigO;

public class BigO_N_SimpleLoop
{
    public bool SimpleLoop(int searchedNumber)
    {
        // O(n)
        var common = new Common();
        foreach (var element in common.OrderedNumbers)
        {
            if (element == searchedNumber)
                return true;
        }

        return false;
    }
}
