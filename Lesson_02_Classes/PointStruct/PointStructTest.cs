using System;

namespace Lesson_02_Classes.PointStruct
{
    public class PointStructTest
    {
        private static void PrintPoint(PointStruct p)
        {
            Console.WriteLine("({0},{1})", p.X, p.Y);
        }

        private static void TryToChangePoint(PointStruct p)
        {
            p.X++;
            p.Y++;
        }

        private static void Main()
        {
            PointStruct point = new PointStruct(3, -2);

            PrintPoint(point);

            TryToChangePoint(point);

            PrintPoint(point);
        }
    }
}