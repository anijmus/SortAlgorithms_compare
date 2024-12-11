using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pr1
{
    public class BubbleSort : Algorithms
    {
        public override void Sort(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }

                }
            }
        }
       
    }
}
