using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_PetShop.Entities
{
    public class Creature
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                age = value;
            }
        }

        public int MaxAge { get; set; }

        public string Speak(string[] words)
        {
            return words[0];
        }
    }
}
