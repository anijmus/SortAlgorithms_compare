using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public abstract class Algorithms
    {
       
       

        public double SortAndTime(int[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Sort(array);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;

        }
        public bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i]) return false;
            }
            return true;
        }
        public abstract void Sort(int[] array);

    }
}

   