namespace Lesson_06_SOLID_Principles.SRP
{
    internal class User
    {
        private string email;
        private string password;

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public override string ToString()
        {
            return FullName;
        }
    }
}