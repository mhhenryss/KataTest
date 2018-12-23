using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    

    public class Kata
    {
        public static int Solution(int value)
        {
            // Magic Happens
            value--;
            int result = SumArithmeticSeries(3, value / 3)
                + SumArithmeticSeries(5, value / 5)
                - SumArithmeticSeries(15, value / 15);
            return result;
        }

        private static int SumArithmeticSeries(int a1, int n)
        {
            return (a1 * (n + 1) * n) / 2;
        }
    }
}
