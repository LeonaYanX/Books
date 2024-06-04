namespace Books.Models
{
    public class User
    {
        public int Id { get; set; }
        public string ?Name { get; set; }

        public string ?Email { get; set; }

        private string ?Password { get; set; }
        public string ?Username { get; set; }

        public string ?ImagePath { get; set; }

        public string ?PhoneNumber { get; set; }

        public string ?City { get; set; }

        public int Age { get; set; }

    }
}
