using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class Kata
    {
        public static int LargestSum(int[] arr)
        {
            // your code to return the largest sum of any subsequence of arr
            int result = 0;
            int tempMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                tempMax = Math.Max(0, tempMax += arr[i]);
                result = Math.Max(result, tempMax);
            }

            return result;
        }
    }
}
