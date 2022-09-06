namespace BigONotation.BigO;

public static class BigO_Log_N_BinarySearch
{
    public static int BinarySearch(List<int> numberElements, int valuesToBeSearched)
    {
        if (numberElements == null)
            throw new ArgumentNullException(nameof(numberElements));

        const int DEFAULT_RETURN = -1;

        if (numberElements[0] > valuesToBeSearched ||
            valuesToBeSearched > numberElements[numberElements.Count - 1])
            return DEFAULT_RETURN;

        int rightBound = numberElements.Count;
        int leftBound = 0;

        while (leftBound < rightBound)
        {
            int middle = (rightBound + leftBound) / 2;

            if (numberElements[middle] < valuesToBeSearched)
                leftBound = middle;
            else if (numberElements[middle] > valuesToBeSearched)
                rightBound = middle;
            else
                return middle;
        }

        return DEFAULT_RETURN;
    }
}
