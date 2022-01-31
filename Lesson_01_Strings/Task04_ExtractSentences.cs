using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_01_Strings
{
    public static class Task04_ExtractSentences
    {
        public static void Run()
        {
            string input = Input();
            string word = "submarine";

            string output = ExtractSentences(input, word);

            Output(output);
        }

        private static string ExtractSentences(string input, string word)
        {
            int startIndex = 0;
            int length = 0;
            int dotIndex = 0;
            string sentence = "";

            int index = input.IndexOf(word);

            while (index != -1)
            {
                dotIndex = input.IndexOf(".", index + 1);
                length = dotIndex - startIndex + 1;

                sentence += input.Substring(startIndex, length) + Environment.NewLine;

                startIndex = dotIndex + 1;

                index = input.IndexOf(word, dotIndex + 1, StringComparison.InvariantCultureIgnoreCase);
            }

            return sentence;
        }

        private static string Input()
        {
            return "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        }

        private static void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
