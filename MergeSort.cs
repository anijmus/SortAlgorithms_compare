using System;
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
            sortMerge(array);
        }



        private static void sortMerge(int[] tab)
        {
            if (tab.Length > 2)
            {
                int[] tab1 = new int[tab.Length / 2];
                int[] tab2 = new int[tab.Length - tab1.Length];

                for (int i = 0; i < tab.Length; i++)
                {
                    if (i < tab1.Length)
                    {
                        tab1[i] = tab[i];
                    }
                    else
                    {
                        tab2[i - tab1.Length] = tab[i];
                    }
                }
                sortMerge(tab1);
                sortMerge(tab2);

                int i1 = 0;
                int i2 = 0;
                while (i1 < tab1.Length || i2 < tab2.Length)
                {
                    if (i1 < tab1.Length && i2 < tab2.Length && tab1[i1] < tab2[i2])
                    {
                        tab[i1 + i2] = tab1[i1];
                        i1++;
                    }
                    else if (i1 < tab1.Length && i2 < tab2.Length && tab1[i1] >= tab2[i2])
                    {
                        tab[i1 + i2] = tab2[i2];
                        i2++;
                    }
                    else if (i1 < tab1.Length)
                    {
                        tab[i1 + i2] = tab1[i1];
                        i1++;
                    }
                    else if (i2 < tab2.Length)
                    {
                        tab[i1 + i2] = tab2[i2];
                        i2++;
                    }
                }

            }
            else if (tab.Length == 2)
            {
                if (tab[0] > tab[1])
                {
                    int tmp = tab[0];
                    tab[0] = tab[1];
                    tab[1] = tmp;
                }
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


