using System;
using System.Collections.Generic;
using System.Text;

namespace Quick_Sort
{
    static class Quick_Sort
    {
        static private int pivot { get; set; } = 0;
        static private int start { get; set; } = 0;
        static private int end { get; set; } = 0;

        //values are not currently retured
        static public void QuickSort(params int[] Values)
        {
            Sort(0, Values.Length - 1, Values);
        }

        static private void Sort(int start, int end, int[] Values)
        {
            if (start < end)
            {
                //assign pivot
                pivot = FindPivot(start, end, Values);

                //check left and right of pivot recursivly
                Sort(start, pivot - 1, Values);
                Sort(pivot + 1, end, Values);
            }
        }

        static private int FindPivot(int start, int end, int[] Values)
        {
            int currentSmallest = start - 1;

            for (int x = start; x < end; x++)
            {
                if(Values[x] <= Values[end])
                {
                    currentSmallest++;
                    Swap(currentSmallest, x, Values);
                }
            }
            currentSmallest++;

            Swap(currentSmallest, end, Values);

            return currentSmallest;
        }

        //O(1)
        static private void Swap(int index1, int index2, int[] values)
        {
            int temptValue = values[index1];
            values[index1] = values[index2];
            values[index2] = temptValue;
        }
    }
}
