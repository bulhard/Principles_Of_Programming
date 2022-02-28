using Lesson_02_Classes.Dogs;
using System;

namespace Lesson_01_Strings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Examples.SlowNumbersConcatenator();
            // Examples.ElegantNumbersConcatenator();

            // Task01_ReverseString.Run();

            // Task02_Parentheses.Run();

            // Task03_SubstringCounter.Run();

            // Task04_ExtractSentences.Run();

            // Task05_HideWords.Run();

            // Task06_UrlParser.Run();

            // Task07_RemoveRepeats.Run();

            // Task08_SortData.Run();

            Task09_ExtractLetters.Run();

            Dog d1 = new Dog();
            d1.Name = "Jessie";
            d1.Bark();

        }
    }
}