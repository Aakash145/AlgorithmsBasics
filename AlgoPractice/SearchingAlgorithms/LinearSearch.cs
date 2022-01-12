using System;
namespace AlgoPractice.SearchingAlgorithms
{
    public class LinearSearch
    {
        public int search(int[] arr, int item)
        {
            int index = -1;
            for(int i = 0; i<= arr.Length -1; i++)
            {
                if(item == arr[i])
                {
                    index = i;
                }
            }

            return index;
        }
    }
}
