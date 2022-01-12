using System;
namespace AlgoPractice.SortingAlgorithms
{
    public class SelectionSort
    {
        public int[] sortMethod(int[] arr)
        {
            for(int i = 0; i<= arr.Length-2; i++)
            {
                int min = i;
                for(int j=i+1; j<= arr.Length-1; j++)
                {
                    if(arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            return arr;
        }
    }
}
