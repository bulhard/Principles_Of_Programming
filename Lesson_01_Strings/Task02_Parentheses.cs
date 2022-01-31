using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_01_Strings
{
    public static class Task02_Parentheses
    {
        public static void Run()
        {
            string input = Input();

            bool output = CheckParentheses(input);

            Output(output);
        }

        private static bool CheckParentheses(string input)
        {
            int index = input.IndexOf("(");

            if (index == -1)
            {
                index = input.IndexOf(")");

                if (index == -1)
                    return true;
                else
                    return false;
            }

            while (index != -1)
            {
                index = input.IndexOf(")", index + 1);
                if (index == -1)
                {
                    return false;
                }
                index = input.IndexOf("(", index + 1);
            }
            
            return true;
        }

        private static string Input()
        {
            Console.Write("Please enter a expression: ");
            return Console.ReadLine();
        }

        private static void Output(bool output)
        {
            Console.Write("Expression parentheses is ");
            Console.Write(output ? "OK" : "Not OK");
        }
    }
}
