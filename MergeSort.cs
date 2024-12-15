﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public class MergeSort : Algorithms
    {
        public override void Sort(int[] array)
        {
            MergeSorting(array, 0, array.Length - 1);
        }

        private void MergeSorting(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSorting(array, left, middle);
                MergeSorting(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        private void Merge(int[] array, int left, int middle, int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            for (int i = 0; i < leftSize; i++)
            {
                leftArray[i] = array[left + i];
            }

            for (int j = 0; j < rightSize; j++)
            {
                rightArray[j] = array[middle + 1 + j];
            }

            int iLeft = 0;
            int iRight = 0;
            int k = left;

            while (iLeft < leftSize && iRight < rightSize)
            {
                if (leftArray[iLeft] <= rightArray[iRight])
                {
                    array[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    array[k] = rightArray[iRight];
                    iRight++;
                }
                k++;
            }

            while (iLeft < leftSize)
            {
                array[k] = leftArray[iLeft];
                iLeft++;
                k++;
            }

            while (iRight < rightSize)
            {
                array[k] = rightArray[iRight];
                iRight++;
                k++;
            }
        }

    }
}










//        private void MergeSortAlgorithm(int[] array, int left, int right)
//        {
//            if (left < right)
//            {
//                int mid = (left + right) / 2;

//                MergeSortAlgorithm(array, left, mid);
//                MergeSortAlgorithm(array, mid + 1, right);

//                Merge(array, left, mid, right);
//            }
//        }

//        private void Merge(int[] array, int left, int mid, int right)
//        {
//            int leftSize = mid - left + 1;
//            int rightSize = right - mid;

//            int[] leftArray = new int[leftSize];
//            int[] rightArray = new int[rightSize];

//            Array.Copy(array, left, leftArray, 0, leftSize);
//            Array.Copy(array, mid + 1, rightArray, 0, rightSize);


//            int i = 0;
//            int j = 0;
//            int k = left;

//            while (i < leftSize && j < rightSize)
//            {
//                if (leftArray[i] <= rightArray[j])
//                {
//                    array[k] = leftArray[i];
//                    i++;
//                }
//                else
//                {
//                    array[k] = rightArray[j];
//                    j++;
//                }
//                k++;
//            }

//            while (i < leftSize)
//            {
//                array[k] = leftArray[i];
//                i++;
//                k++;
//            }

//            while (j < rightSize)
//            {
//                array[k] = rightArray[j];
//                j++;
//                k++;
//            }
//        }
//    }
//}


