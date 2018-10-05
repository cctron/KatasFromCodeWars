using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Business
{
    public class KataSimpleEncryptionAlternatingSplit
    {
        public static string Encrypt(string text, int n)
        {
            if (String.IsNullOrEmpty(text)) return text;
            if (n <= 0) return text;

            return DoEncryptation(text,n);
        }

        private static string DoEncryptation(string text, int n)
        {
           string textToEncrypted = string.Empty;
            int i = 1;
            int loop = 1;
            string finalText = string.Empty;


            while (loop <= n)
            {
                if (loop > 1)
                {
                    text = textToEncrypted;
                    textToEncrypted = string.Empty;
                }


                while (textToEncrypted.Length != text.Length)
                {
                    if (!string.IsNullOrEmpty(textToEncrypted))
                    { i = 0; }
                    else { i = 1; }

                    while (i <= text.Length - 1)
                    {
                        textToEncrypted = string.Concat(textToEncrypted, ExtractChar(text, i));

                        i += 2;
                    }
                }

                ++loop;

            }

            finalText = textToEncrypted;
            

            return finalText;
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
