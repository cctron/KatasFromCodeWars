using System;
using System.Collections.Generic;
using System.Linq;


namespace Katas.Business
{
    public class KataLongestConsecutives
    {
        public static String LongestConsec(string[] strarr, int k)
        {
            List<string> stringList = GetStringsFromArray(strarr: strarr, k: k);

            var sortedValues = stringList
            .OrderByDescending(x => x.Length);

            var finalString = sortedValues.FirstOrDefault();

            if (finalString is null) return "";

            if (finalString.Length == 0 || k > finalString.Length || k <= 0) return "";

            return finalString;
        }

        private static List<string> GetStringsFromArray(string[] strarr, int k)
        {
            List<string> stringList = new List<string>();
            int pos = 0;
            while ((pos + k) <= strarr.Length)
            {
                stringList.Add(GenerateString(strarr: strarr, pos: pos,
                k: k - 1, concat: "", start: 0));
                pos += 1;
            }

            return stringList;
        }

        private static string GenerateString(string[] strarr, int pos, int k, string concat, int start)
        {
            while (start <= k)
            {
                concat = String.Concat(concat, strarr[pos]);
                ++pos;
                ++start;
            }

            return concat;
        }
    }
}
