using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public class SelectionSort : Algorithms
    {
        public override void Sort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (array[j] < array[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first element
                int temp = array[min_idx];
                array[min_idx] = array[i];
                array[i] = temp;
            }   
        }
    }
}
