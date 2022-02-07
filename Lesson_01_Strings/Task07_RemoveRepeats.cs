using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_01_Strings
{
    internal class Task07_RemoveRepeats
    {
        public static void Run()
        {
            var url = Input();

            var logic = RemoveRepeats(url);

            Output(logic);
        }

        public static string Input()
        {
            return "aaaaabbbbbcdddeeeedssaa";
        }

        public static string RemoveRepeats(string input)
        {
            StringBuilder sb = new StringBuilder();
            char currentLetter = new char();

            for (int i = 0; i < input.Length; i++)
            {
                if (currentLetter != input[i])
                {
                    currentLetter = input[i];
                    sb.Append(currentLetter);
                }
            }

            return sb.ToString();
        }

        public static void Output(string output)
        {
            Console.WriteLine($"Extracted sentence: {output}");
        }
    }
}