using System;
using System.Collections.Generic;
using System.Text;

namespace Quick_Sort
{
    static class Quick_Sort
    {
        static private int pivot { get; set; } = 0;

        static Quick_Sort()
        {
        }

        static void Sort(params int[] Values)
        {
            if(pivot == 0)
            {
                pivot = Values.Length - 1;
            }
            //assign pivot
             pivot = CPosition(Values, 0);

            //check right and left of pivot recursivly

        }

        static int CPosition(int[] Values, int pivot)
        {
            int currentSmallest = -1;

            for (int x = 0; x < Values.Length; x++)
            {

            }

            return Values;
        }
    }
}
