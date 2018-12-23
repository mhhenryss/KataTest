using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    

    public class Kata
    {
        private static List<int> result;
        public static List<int> PascalsTriangle(int n)
        {
            result = new List<int> { };
            if (n == 0)
                return result;
            AddPascalsTriangle(n);
            return result;
        }

        public static List<int> AddPascalsTriangle(int n)
        {
            if(n == 1)
            {
                result.Add(1);
                return new List<int> { 1 };
            }
            else
            {
                List<int> listNow = new List<int>();
                List<int> listLast = AddPascalsTriangle(n - 1);

                listNow.Add(1);
                for (int i = 0; i < listLast.Count - 1; i++)
                    listNow.Add(listLast[i] + listLast[i + 1]);
                listNow.Add(1);

                result.AddRange(listNow);
                return listNow;
            }
        }
    }
}
