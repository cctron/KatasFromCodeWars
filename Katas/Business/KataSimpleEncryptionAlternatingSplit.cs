using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Business
{
    public class KataSimpleEncryptionAlternatingSplit
    {
        public static string Encrypt(string text, int n)
        {
            if (String.IsNullOrEmpty(text)) return text;
            if (n <= 0) return text;

            return DoEncryptationRefactor(text, n);
        }

        private static string DoEncryptationRefactor(string text, int n)
        {
            List<string> OddPosition;
            List<string> EvenPosition;
            string result;
            int loop = 0;
            int i = 0;

            result = text;
            while (loop < n)
            {
                OddPosition = new List<string>();
                EvenPosition = new List<string>();
                i = 0;

                while (i <= result.Length - 1)
                {
                    if (i % 2 == 0) OddPosition.Add(result.Substring(i, 1));
                    if (i % 2 != 0) EvenPosition.Add(result.Substring(i, 1));

                    ++i;
                }

                result = string.Concat(EvenPosition.Select(x => x).Aggregate((x, j) => x + j),
                    OddPosition.Select(x => x).Aggregate((x, j) => x + j));

                ++loop;
            }

            return result;

        }


        private static string ExtractChar(string text, int i)
        {
            return text.Substring(i, 1);
        }


        public static string Decrypt(string encryptedText, int n)
        {

            if (string.IsNullOrEmpty(encryptedText)) return encryptedText;
            if (n <= 0) return encryptedText;

            return encryptedText;

        }
    }
}
