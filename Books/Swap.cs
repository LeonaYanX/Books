﻿using System;
using System.Collections.Generic;

namespace Books;

public partial class Swap
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
