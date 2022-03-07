using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_Generics.AnimalShelterDemo
{
    public class SwapDemo
    {
        public static void Swap<K>(ref K a, ref K b)
        {
            K oldA = a;
            a = b;
            b = oldA;
        }
    }
}
