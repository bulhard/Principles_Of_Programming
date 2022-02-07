using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_01_Strings
{
    internal class Task06_UrlParser
    {
        public static void Run()
        {
            var url = Input();

            var logic = ParseUrl(url);

            Output(logic);
        }

        public static string Input()
        {
            return "http://www.cnn.com/video";
        }

        public static string ParseUrl(string input)
        {
            int startPosition = 0;

            string protocolSeparator = "://";
            string urlSeparator = "/";

            // Protocol
            int indexOne = input.IndexOf(protocolSeparator);
            int lengthOne = indexOne - startPosition;

            string protocol = input.Substring(startPosition, lengthOne);

            // Server
            indexOne = indexOne + protocolSeparator.Length;
            int indexTwo = input.IndexOf(urlSeparator, indexOne);
            var lengthTwo = indexTwo - indexOne;

            string server = input.Substring(indexOne, lengthTwo);

            // Resource
            indexTwo = indexTwo + urlSeparator.Length;
            string resource = input.Substring(indexTwo);

            string extract = "Protocol: " + protocol + " Server: " + server + " Resource: " + resource;
            return extract;
        }

        public static void Output(string output)
        {
            Console.WriteLine($"Extracted sentence: {output}");
        }
    }
}