using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public class InsertionSort : Algorithms
    {
        public override void Sort(int[] array)
        {

            for(int posortowanedo = 1; posortowanedo < array.Length; posortowanedo++) 
            {
                int iddozamiany = posortowanedo;

                while (iddozamiany>0 && array[iddozamiany] < array[iddozamiany-1])
                {
                    int tmp = array[iddozamiany];
                    array[iddozamiany] = array[iddozamiany - 1];
                    array[iddozamiany-1] = tmp;
                    iddozamiany--;

                }
            }
        }

    }
}
