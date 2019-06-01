using System;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers = new int[8] {5,2,1,4,9,5,3,2};
            Quick_Sort.QuickSort(numbers);

            foreach (int value in numbers)
            {
                Console.Write(value);
            }
        }
    }
}
