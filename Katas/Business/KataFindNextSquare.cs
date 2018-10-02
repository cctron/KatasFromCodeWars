using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class KataFindNextSquare
    {
        public static long FindNextSquare(long num)
        {
            double result = Math.Sqrt(num);
            bool isSquare = result % 1 == 0;
            if (isSquare == true)
            {
                result++;
                result *= result;
                long l = Convert.ToInt64(result);
                return l;
            }
            else
            {
                return -1;
            }
        }
    }
}
