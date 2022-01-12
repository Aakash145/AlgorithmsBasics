using System;
namespace AlgoPractice.SortingAlgorithms
{
    public class MergeSort
    {
        public int[] sortMethod(int[] arr)
        {
            int n = arr.Length;
            if(n < 2){
                return arr;
            }
            int mid = n / 2;
            int[] leftArr = new int[mid];
            int[] rightArr = new int[n-mid];

            for(int i=0; i< mid; i++)
            {
                leftArr[i] = arr[i];
            }

            for(int j= mid; j< n; j++)
            {
                rightArr[j - mid] = arr[j];
            }

            sortMethod(leftArr);
            sortMethod(rightArr);
            merge(leftArr, rightArr, arr);

            return arr;
        }

        public void merge(int[] arrLeft, int[] arrRight, int[] arr) {
            int leftArrLength = arrLeft.Length;
            int rightArrLength = arrRight.Length;
            int i = 0, j = 0, k = 0;

            while(i < leftArrLength && j < rightArrLength)
            {
                if(arrLeft[i] <= arrRight[j])
                {
                    arr[k] = arrLeft[i];
                    i = i + 1;
                    k = k + 1;
                }
                else
                {
                    arr[k] = arrRight[j];
                    j = j + 1;
                    k = k + 1;
                }
            }

            while(i < leftArrLength)
            {
                arr[k] = arrLeft[i];
                i = i + 1;
                k = k + 1;
            }

            while (j < rightArrLength)
            {
                arr[k] = arrRight[j];
                j = j + 1;
                k = k + 1;
            }
        }

    }
}
