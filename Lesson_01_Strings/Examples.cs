using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson_01_Strings
{
    public static class Examples
    {
        public static void SlowNumbersConcatenator()
        {
            Console.WriteLine(DateTime.Now);
            string collector = "Numbers: ";
            for (int index = 1; index <= 200000; index++)
            {
                collector += index;
            }
            Console.WriteLine(collector.Substring(0, 1024));
            Console.WriteLine(DateTime.Now);
        }

        public static void ElegantNumbersConcatenator()
        {
            Console.WriteLine(DateTime.Now);
            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");
            for (int index = 1; index <= 200000; index++)
            {
                sb.Append(index);
            }
            Console.WriteLine(sb.ToString().Substring(0, 1024));
            Console.WriteLine(DateTime.Now);
        }

        public static void ReverseText()
        {
            string text = "EM edit";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);
        }

        private static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }

        public static string ExtractCapitals(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Uppercase first letters of all words in the string.
        /// </summary>
        public static string UpperFirst(string s)
        {
            return Regex.Replace(s, @"\b[a-z]\w+", delegate (Match match)
            {
                string v = match.ToString();
                return char.ToUpper(v[0]) + v.Substring(1);
            });
        }
    }
}