using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    

    public class Kata
    {
        public static int FindMissing(List<int> list)
        {
            /*long listSum = list.Sum(x => Convert.ToInt32(x));
            long orgSum = ((list[0] + list[list.Count - 1]) * (list.Count + 1)) / 2;
            return (int)(orgSum - listSum);*/
            int d1 = list[1] - list[0];
            int d2 = list[2] - list[1];

            if (d1 > d2)
                return list[0] + d2;
            else if (d1 < d2)
                return list[1] + d1;
            else
                for (int i = 2; i < list.Count - 1; i++)
                {
                    if (list[i + 1] - list[i] != d1)
                        return list[i] + d1;
                }

            return 0;
        }
    }
}
