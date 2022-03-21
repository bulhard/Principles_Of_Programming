using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_Principles_OOP.AbstractClass
{
    public class Lion : Felidae
    {
        protected void Ambush()
        {
            // …
        }

        public override bool CatchPrey(object prey)
        {
            base.Hide();
            this.Ambush();
            base.Run();
            // …
            return false;
        }
    }
}