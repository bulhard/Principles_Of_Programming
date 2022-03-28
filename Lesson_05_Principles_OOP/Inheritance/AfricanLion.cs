namespace Lesson_05_Principles_OOP.Inheritance
{
    public class AfricanLion : Lion
    {
        // …
        // If we comment out the ": base(male, weight)" line
        // the class will not compile. Try it.
        public AfricanLion(bool male, int weight) : base(male, weight)
        {
            weight = weight - 10;
        }

        public override string ToString()
        {
            return string.Format("(AfricanLion, male: {0}, weight: {1})", Male, Weight);
        }

        // …
    }
}