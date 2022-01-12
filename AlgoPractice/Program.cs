using System;
using AlgoPractice.SortingAlgorithms;

namespace AlgoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 8, 10, 3, 0, 6};
            //BubbleSort sort = new BubbleSort();
            //int[] sortedArr = sort.sortMethod(arr);
            //SelectionSort sort = new SelectionSort();
            //int[] sortedArr = sort.sortMethod(arr);
            //InsertionSort sort = new InsertionSort();
            //int[] sortedArr = sort.sortMethod(arr);
            //MergeSort sort = new MergeSort();
            //int[] sortedArr = sort.sortMethod(arr);
            //QuickSort sort = new QuickSort();
            //int[] sortedArr = sort.quickSort(arr, 0, arr.Length-1);
            //printArray(sortedArr);
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
    }
}
