using System;
using System.Collections.Generic;

namespace Books;

public partial class OptionalPostponed
{
    public int? IdBook { get; set; }

    public int? IdUser { get; set; }

    public virtual Book? IdBookNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
