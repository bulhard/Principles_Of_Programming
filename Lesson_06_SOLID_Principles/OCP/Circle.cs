using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_SOLID_Principles.OCP
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius* Radius* Math.PI;
        }
    }
}
