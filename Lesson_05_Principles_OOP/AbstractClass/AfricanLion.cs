using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_Principles_OOP.AbstractClass
{
    public class AfricanLion : Felidae
    {
        public override bool CatchPrey(object prey)
        {
            return true;
        }
    }
}