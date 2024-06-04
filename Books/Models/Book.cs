namespace Books.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int  idTitle  { get; set; }

        public int idAuthor { get; set; }

        public decimal price { get; set; }

        public bool isSwapeble { get; set; }

        public Catalog idCatalog { get; set; }

        public int idPhoto { get; set; }

        public int idUser { get; set; }

        public string Info { get; set; }
    }
}
