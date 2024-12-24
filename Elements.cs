using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public enum ElementType
    {
        Losowe,
        Rosnące,
        Malejące
    }
    public class Elements
    {
        private Random random = new Random();
        public int[] elements;
        public int[] GenerateElements(int size, ElementType eType)
        {
            elements = new int[size];

            switch (eType)
            {
                case ElementType.Losowe:
                    for (int i = 0; i < size; i++)
                    {
                        elements[i] = random.Next(1, 100);
                    }
                    break;

                case ElementType.Rosnące:
                    for (int i = 0; i < size; i++)
                    {
                        elements[i] = i + 1;
                    }
                    break;

                case ElementType.Malejące:
                    for (int i = 0; i < size; i++)
                    {
                        elements[i] = size - i;
                    }
                    break;
            }
            return elements;
        }
    }
}
