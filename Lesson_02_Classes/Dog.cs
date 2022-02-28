using System;

namespace Lesson_02_Classes.Dogs
{
    // Class declaration
    public class Dog
    { // Opening bracket of the class body

        const string defaultDogName = "[unnamed dog]";

        // Field declaration
        private string name;

        // Constructor declaration (peremeterless empty constructor)
        public Dog()
        { }

        // Another constructor declaration
        public Dog(string name)
        {
            this.name = name;
        }

        // Property declaration
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Method declaration (non-static)
        public void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!", name ?? defaultDogName);
        }
    } // Closing bracket of the class bod
}