﻿using Lesson_05_Principles_OOP.Inheritance;

namespace Lesson_05_Principles_OOP.Abstraction
{
    public class WildLion : Felidae, IReproducible<Lion>
    {
        // …
        public Lion[] Reproduce(Lion mate)
        {
            return new Lion[] { new Lion(true, 12), new Lion(false, 10) };
        }
    }
}