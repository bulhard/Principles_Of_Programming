using Lesson_05_Principles_OOP.Inheritance;
using System;

namespace Lesson_05_Principles_OOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // Overrride live demo example
            Console.WriteLine(new object());
            Console.WriteLine(new Felidae(true));
            Console.WriteLine(new Lion(true, 80));
            Console.WriteLine(new AfricanLion(true, 80));

            var lion = new AfricanLion(true, 80);

        }
    }
}