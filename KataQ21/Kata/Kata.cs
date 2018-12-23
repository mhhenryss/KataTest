using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    
    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            int[] oddarray = array.Where<int>(x => x % 2 == 1).OrderBy(x => x).ToArray<int>();
            for(int i = 0, j = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 1)
                {
                    array[i] = oddarray[j];
                    j++;
                }
            }
            
            return array;
        }
    }
}
