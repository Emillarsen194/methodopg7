using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg7
{
    class Logic
    {
        public static int ArrayIndex() //make our array and return index of 5
        {
            int[] array = new int[9];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                if (array[i] == array[5])
                {
                    return array[5] * 2;
                }
            }

            return array[5];
        }
    }
}
