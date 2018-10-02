using System;
using System.Linq;

namespace Katas
{
    public class KataCountingBits
    {
        
        public static int CountBits(int n)
        {
            string pattern = "1";

            //refactor
            //return Convert.ToString(n, 2).Count(x => x == '1');

            return CountingOnes(TransformtoBinary(n), pattern);

            
        }

        private static string TransformtoBinary(int value)
        {
            return Convert.ToString(value, 2);
        }

        private static int CountingOnes(string binaryValue, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = binaryValue.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
