using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lesson_01_Strings
{
    public static class Task04_ExtractSentences
    {
        public static void Run()
        {
            string input = Input();
            string word = "submarine";

            string output = ExtractSentences1(input, word);

            Output(output);
        }

        private static string ExtractSentences1(string input, string word)
        {
            input += " ";
            var result = "";
            var startIndex = 0;
            var dotIndex = input.IndexOf(". ");

            while (dotIndex != -1)
            {
                var length = dotIndex - startIndex + 1;
                var sentence = input.Substring(startIndex, length);

                if (sentence.Contains(word, StringComparison.InvariantCultureIgnoreCase))
                {
                    result += sentence.Trim() + Environment.NewLine;
                }

                startIndex = dotIndex + 1;
                dotIndex = input.IndexOf(". ", dotIndex + 1);
            }

            return result;
        }

        public static string ExtractSentences2(string input, string patternWord)
        {
            //Step 1: fragment phrase.
            // https://cheatography.com/davechild/cheat-sheets/regular-expressions/

            var patternPhrase = @"(?<=(^|[.!?]\s*))[^ .!?][^.!?]+[.!?]\s{1}";
            input += " ";

            var matches_1 = Regex
                .Matches(input, patternPhrase) // step 1
                .Cast<Match>()
                .Select(s => s.Value)
                .Where(w => Regex.IsMatch(w, patternWord, RegexOptions.IgnoreCase)); // step 2

            var sentences = Regex.Matches(input, patternPhrase);
            var matches_2 = sentences.Where(s => s.Value.Contains(patternWord)).ToList();

            var result = "";
            foreach (var item in matches_2)
            {
                result += item + Environment.NewLine;
            }

            return result;
        }

        private static string Input()
        {
            return "We are living in a 1.2 yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of submarine in 5 days.";
        }

        private static void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}