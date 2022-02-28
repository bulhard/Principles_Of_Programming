namespace Lesson_02_Classes.StaticDogCount
{
    public class Dog
    {
        // Static (class) variable
        public static int dogCount = 0;

        // Instance variables
        private string name;

        private int age;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;

            // Modifying the static counter in the constructor
            Dog.dogCount += 1;
        }
    }
}