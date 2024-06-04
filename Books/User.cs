using System;
using System.Collections.Generic;

namespace Books;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public byte[]? Photo { get; set; }

    public string Telephone { get; set; } = null!;

    public string City { get; set; } = null!;

    public int Age { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
