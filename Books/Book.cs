using System;
using System.Collections.Generic;

namespace Books;

public partial class Book
{
    public int Id { get; set; }

    public int? IdTitle { get; set; }

    public int? IdAuthor { get; set; }

    public int? Price { get; set; }

    public int? IdSwap { get; set; }

    public int? IdCatalog { get; set; }

    public int? IdPhoto { get; set; }

    public int? IdUser { get; set; }

    public byte[]? Info { get; set; }

    public virtual Author? IdAuthorNavigation { get; set; }

    public virtual Catalog? IdCatalogNavigation { get; set; }

    public virtual Galary? IdPhotoNavigation { get; set; }

    public virtual Swap? IdSwapNavigation { get; set; }

    public virtual Title? IdTitleNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
