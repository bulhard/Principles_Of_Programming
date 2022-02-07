using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_01_Strings
{
    internal class Task08_SortData
    {
        public static void Run()
        {
            var url = Input();

            var logic = SortData(url);

            Output(logic);
        }

        public static string Input()
        {
            return "web, mobile, desktop, games, IoT";
        }

        public static string[] SortData(string input)
        {
            string[] delimiters = { ",", " " };
            var data = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(data);

            return data;
        }

        public static void Output(string[] output)
        {
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}