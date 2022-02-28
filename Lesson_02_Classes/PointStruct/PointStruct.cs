namespace Lesson_02_Classes.PointStruct
{
    internal struct PointStruct
    {
        private double x;
        private double y;

        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}