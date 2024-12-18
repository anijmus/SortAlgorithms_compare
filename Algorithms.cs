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
        public abstract void Sort(int[] array);

    }
}

   