using System;
using System.Collections.Generic;

namespace Books;

public partial class Catalog
{
    public int Id { get; set; }

    public string Category { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
