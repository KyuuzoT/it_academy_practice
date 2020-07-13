using System;
using System.Collections.Generic;
using System.Text;

namespace Task_14_2
{
    static class StringExtension
    {
        public static string TrimString(this String str, int numberOfLetters)
        {
            return $"{str.Substring(0, numberOfLetters)}...";
        }

        public static string TrimString(this String str, int start, int end)
        {
            string trimmed = String.Empty;
            for (int i = 0; i < end - start; i++)
            {
                trimmed += str[i + start];
            }

            if(start > 0)
            {
                return $"...{trimmed}...";
            }
            return $"{trimmed}...";
        }
    }
}
