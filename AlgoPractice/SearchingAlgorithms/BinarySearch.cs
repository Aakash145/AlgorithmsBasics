using System;
namespace AlgoPractice.SearchingAlgorithms
{
    public class BinarySearch
    {
        public int search(int[] arr, int start, int end, int item)
        {
            int mid = (start+end)/ 2;

            if(item == arr[mid])
            {
                return mid;
            }
            else if(item <= arr[mid])
            {
                return search(arr, start, mid - 1, item);
            }
            else if(item >= arr[mid])
            {
                return search(arr, mid + 1, end, item);
            }
            return -1;
        }

    }
}