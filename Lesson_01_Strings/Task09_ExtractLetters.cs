using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_01_Strings
{
    public static class Task09_ExtractLetters
    {
        public static void Run()
        {
            var input = Input();

            var output = ExtractLetters(input);

            Output(output);
        }

        public static int[] ExtractLetters(string input)
        {
            /*
                Use an array of integers int[65536], which will keep how many times
                each letter occurs. Initially, all array elements are zeros. After
                processing the input string letter by letter you can write in the array how
                many times each letter occurs. For example, if you meet the letter 'A',
                the number of occurrences in the array index of 65 (Unicode code 'A') will
                increase by one. Finally, all non-zero elements (convert array index to
                char, to get the letter) and their number of occurrences can be printed
                with one scan of the array.
             */

            var result = new int[65536];

            var inputArray = input.ToCharArray();

            foreach (char letter in inputArray)
            {
                result[(int)letter]++;
            }

            return result;
        }

        private static string Input()
        {
            return "We are living in a 1.2 yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of submarine in 5 days.";
        }

        private static void Output(int[] output)
        {
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] > 0)
                {
                    Console.WriteLine($"Letter {(char)i} : {output[i]} times");
                }
            }
        }
    }
}
