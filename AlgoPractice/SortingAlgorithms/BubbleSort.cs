using System;
namespace AlgoPractice.SortingAlgorithms
{
    public class BubbleSort
    {
        public int[] sortMethod(int[] arr)
        {
            for(int i = 0; i < arr.Length -1; i++)
            {
                Boolean flag = false;
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j+1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        flag = true;
                    }
                }
                if(flag == false)
                {
                    break;
                }
            }
            return arr;
        }
    }
}
