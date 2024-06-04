using System;
using System.Collections.Generic;

namespace Books;

public partial class Galary
{
    public int Id { get; set; }

    public string Path { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
