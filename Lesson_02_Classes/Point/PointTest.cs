using System;

namespace Lesson_02_Classes.Point
{
    public class PointTest
    {
        public void Run()
        {
            Point myPoint = new Point(2, 3);

            double myPointXCoord = myPoint.X; // Access a property
            double myPointYCoord = myPoint.Y; // Access a property

            Console.WriteLine("The X coordinate is: " + myPointXCoord);
            Console.WriteLine("The Y coordinate is: " + myPointYCoord);
        }
    }
}