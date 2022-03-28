using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_Principles_OOP.Encapsulation
{
    public class Lion : Felidae
    {
        // …
        private Paw frontLeft;
        private Paw frontRight;
        private Paw bottomLeft;
        private Paw bottomRight;

        private void MovePaw(Paw paw)
        {
            // …
        }

        public override void Walk()
        {
            MovePaw(frontLeft);
            MovePaw(frontRight);
            MovePaw(bottomLeft);
            MovePaw(bottomRight);
        }

        // …
    }
}