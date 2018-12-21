using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    

    public class Kata
    {
        public static bool IsAnagram(string test, string original)
        {
            string testLower = test.ToLower();
            string originalLower = original.ToLower();
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char s in originalLower)
            {
                if (dic.ContainsKey(s))
                {
                    dic[s] += 1;
                }
                else
                    dic.Add(s, 1);
            }

            foreach (char s in testLower)
            {
                if (dic.ContainsKey(s))
                {
                    dic[s] -= 1;
                    if(dic[s] == 0)
                        dic.Remove(s);
                }
                else
                    return false;
            }

            if (dic.Count == 0)
                return true;
            else
                return false;
        }
    }
}
