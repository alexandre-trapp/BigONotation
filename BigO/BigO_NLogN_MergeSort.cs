using BigONotation.Benchmark;
using System.Text;

namespace BigONotation.BigO;

public class BigO_NLogN_MergeSort
{
    // O(n log n)
    public void OrderingMergeSort()
    {
        var common = new Common();
        var numbersMergeSort = MergeSort(common.UnorderedNumbers.ToArray<int>(), 0, common.UnorderedNumbers.Count -1).ToList<int>();

        var sbMergeSort = new StringBuilder();

        for (int count = 0; count < numbersMergeSort.Count; count++)
        {
            sbMergeSort.Append(numbersMergeSort[count].ToString() + "==>");
        }

        Console.WriteLine(sbMergeSort.ToString());  
    }

    private int[] MergeSort(int[] inputItems, int leftBound, int rightBound)
    {
        if (leftBound > rightBound)
            return inputItems;

        int middle = (leftBound + rightBound) /2;

        MergeSort(inputItems, leftBound, middle);
        MergeSort(inputItems, middle + 1, rightBound);

        int[] leftArray = new int[middle - leftBound +1];
        int[] rightArray = new int[rightBound - middle];

        Array.Copy(inputItems, leftBound, leftArray, 0, middle - leftBound +1);
        Array.Copy(inputItems, middle + 1, rightArray, 0, rightBound - middle);

        int i = 0;
        int j = 0;

        for (int count = leftBound; count < rightBound +1; count++)
        {
            if (i == leftArray.Length)
            {
                inputItems[count] = rightArray[j];
                j++;
            }
            else if (j == rightArray.Length)
            {
                inputItems[count] = leftArray[i];
                i++;
            }
            else if (leftArray[i] <= rightArray[j])
            {
                inputItems[count] = leftArray[i];
                i++;
            }
            else
            {
                inputItems[count] = rightArray[j];
                j++;
            }
        }

        return inputItems;
    }
}
