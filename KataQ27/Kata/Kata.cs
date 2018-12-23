using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    

    public class Kata
    {
        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int highestTimes = 0;

            if (arr.Length <= 2)
                return arr.Max();

            foreach (int val in arr)
            {
                if (dic.ContainsKey(val))
                {
                    dic[val] += 1;
                    highestTimes = Math.Max(highestTimes, dic[val]);
                }
                else
                    dic.Add(val, 1);
            }

            if (highestTimes == 0)
                return arr.Max();

            List<int> highestNumbers = new List<int>();

            foreach (KeyValuePair<int, int> item in dic)
            {
                if (item.Value == highestTimes)
                    highestNumbers.Add(item.Key);
            }

            return highestNumbers.Max(x => x);
        }
    }
}
