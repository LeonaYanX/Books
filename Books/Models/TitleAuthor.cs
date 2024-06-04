using System.Security.Cryptography.X509Certificates;

namespace Books.Models
{
    public class Title
    {
       public int Id { get; set; }
        public string ?titleName { get; set; }

        public int idAuthor = (new Author() { Id = 1, Name = "Roger Jelyazni" }).Id;

    }
}
