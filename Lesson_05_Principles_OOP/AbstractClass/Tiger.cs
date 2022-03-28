using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_Principles_OOP.AbstractClass
{
    public class Tiger : Felidae
    {
        protected bool Kill()
        {
            return true;
        }

        public override bool CatchPrey(object prey)
        {
            base.Hide();

            return Kill();
        }
    }
}
