using System;
namespace AlgoPractice.SortingAlgorithms
{
    public class QuickSort
    {
        public int[] quickSort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int pivot = partition(arr, start, end);
                quickSort(arr, start, pivot - 1);
                quickSort(arr, pivot+1, end);
            }
            return arr;
        }

        public int partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int index = start - 1;
            for(int j = start; j< end; j++)
            {
                if(arr[j] <= pivot)
                {
                    index++;
                    int temp1 = arr[index];
                    arr[index] = arr[j];
                    arr[j] = temp1;
                }
            }
            int temp2 = arr[index + 1];
            arr[index + 1] = arr[end];
            arr[end] = temp2;

            return index + 1;
        }

    }
}
