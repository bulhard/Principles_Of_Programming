using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_01_Strings
{
    public static class Task03_SubstringCounter
    {
        public static void Run()
        {
            string input = Input();
            string searchString = "in";

            int output = CountOfSubstring(input, searchString);

            Output(output);
        }

        private static int CountOfSubstring(string input, string searchString)
        {
            var result = 0;

            int index = input.IndexOf(searchString);

            while (index != -1)
            {
                result++;
                index = input.IndexOf(searchString, index + 1, StringComparison.InvariantCultureIgnoreCase);
            }

            return result;
        }

        private static string Input()
        {
            return "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        }

        private static void Output(int output)
        {
            Console.Write($"The result is {output} occurrences");
        }
    }
}
