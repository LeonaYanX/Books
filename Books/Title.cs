using System;
using System.Collections.Generic;

namespace Books;

public partial class Title
{
    public int Id { get; set; }

    public string Title1 { get; set; } = null!;

    public int? IdAutor { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual Author? IdAutorNavigation { get; set; }
}
