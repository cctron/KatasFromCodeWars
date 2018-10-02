using System;
using System.Linq;

namespace Katas
{
    public class KataMumbling
    {
        public static String Accum(string s)
        {

            int i = 1;
            string result = s.First().ToString().ToUpper();
            while(i < s.Length)
            {
                result += string.Format("-{0}{1}",
                    s.Substring(i, 1).ToUpper(),
                    RepeatLetter(s.Substring(i,1).ToLower() ,i));

                i++;
            }

            return result;
        }

        private static string RepeatLetter(string character, int position)
        {
            return string.Concat(Enumerable.Repeat(character, position));
        }
    }
}
