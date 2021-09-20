using System;
using System.Collections.Generic;
using System.Text;

namespace OIP
{
    class Visener
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        readonly string letters;

        string tempKey = "";

        public Visener(string alphUser = null)
        {
            letters = string.IsNullOrEmpty(alphUser) ? alphabet : alphUser;
        }
        private string RepeatKey(string key, int n)
        {
            string tempKey = key;

            while (tempKey.Length < n)
            {
                tempKey += tempKey;
            }

            return tempKey.Substring(0, n);
        }

        public string Shifr(string text, string key)
        {

            tempKey = RepeatKey(key, text.Length);

            string encryptedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                encryptedText += alphabet[(alphabet.Length + text[i] + tempKey[i]) % alphabet.Length];
            }

            return encryptedText;

        }
        public string DeShifr(string encrText, string key)
        {
            string decrText = "";
            tempKey = RepeatKey(key, encrText.Length);
            tempKey.ToUpper();
            for (int i = 0; i < encrText.Length; i++)
            {
                decrText += alphabet[(alphabet.Length + encrText[i] - tempKey[i]) % alphabet.Length];
            }

            return decrText;
        }
    }
}
