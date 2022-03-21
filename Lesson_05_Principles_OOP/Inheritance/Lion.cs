namespace Lesson_05_Principles_OOP.Inheritance
{
    public class Lion : Felidae
    {
        private int weight;

        // Keyword "base" will be explained in the next paragraph
        public Lion(bool male, int weight) : base(male)
        {
            this.weight = weight;
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}