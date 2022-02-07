using System;
using System.Text;

namespace Lesson_01_Strings
{
    public static class Task05_HideWords
    {
        public static void Run()
        {
            string input = Input();
            string words = "C#,CLR,Microsoft";

            string output = HideWords(input, words);

            Output(output);
        }

        private static void Output(string output)
        {
            Console.WriteLine(output);
        }

        private static string HideWords(string input, string words)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input);

            var wordsArr = words.Split(",", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in wordsArr)
            {
                sb.Replace(word, new string('*', word.Length));
            }

            return sb.ToString();
        }

        public static string Input()
        {
            return "Microsoft announced its next generation C# compiler today.It uses advanced parser and special optimizer for the Microsoft CLR.";
        }
    }
}