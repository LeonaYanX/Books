using System;
using System.Collections.Generic;

namespace Books;

public partial class Author
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual ICollection<Title> Titles { get; set; } = new List<Title>();
}
