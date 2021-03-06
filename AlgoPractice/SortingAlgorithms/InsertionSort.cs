using System;
namespace AlgoPractice.SortingAlgorithms
{
    public class InsertionSort
    {
        public int[] sortMethod(int[] arr)
        {
            for(int i = 1; i <=arr.Length-1; i++)
            {
                int value = arr[i];
                int hole = i;
                while(hole > 0 && arr[hole-1] > value)
                {
                    arr[hole] = arr[hole - 1];
                    hole = hole - 1;
                }
                arr[hole] = value;
            }
            return arr;
        }
    }
}
