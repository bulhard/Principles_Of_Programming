using System;

namespace Lesson_02_Classes.StaticDogCount
{
    public class StaticDogTest
    {
        private static void Run()
        {
            Dog dog1 = new Dog("Jackie", 1);
            Dog dog2 = new Dog("Lassy", 2);
            Dog dog3 = new Dog("Rex", 3);

            // Access to the static variable
            Console.WriteLine("Dog count is now " + Dog.dogCount);
        }
    }
}