using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    

    public class Kata
    {
        public static string ReverseWords(string str)
        {
            //Write your code here
            if (str.Count<char>() <= 1)
                return str;

            string result = "";
            string[] words = str.Split(' ');

            foreach (string s in words)
            {
                if(s.Count<char>() > 0)
                {
                    string sReverse = new string(s.Reverse().ToArray());
                    result += (sReverse + " ");
                }
            }

            if (str[0].ToString() == " ")
                result = " " + result;

            if (str[str.Count<char>() - 1].ToString() == " ")
                return result;
            else
                return result.Remove(result.Count<char>() - 1, 1);
        }
    }
}
