using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Books;

public partial class DataBaseBooksContext : DbContext
{
    public DataBaseBooksContext()
    {
    }

    public DataBaseBooksContext(DbContextOptions<DataBaseBooksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Catalog> Catalogs { get; set; }

    public virtual DbSet<Galary> Galaries { get; set; }

    public virtual DbSet<Messenger> Messengers { get; set; }

    public virtual DbSet<OptionalPostponed> OptionalPostponeds { get; set; }

    public virtual DbSet<PriceCategory> PriceCategories { get; set; }

    public virtual DbSet<Swap> Swaps { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\Users\\User\\OneDrive\\Desktop\\BukinistDB\\DataBaseBooks.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.ToTable("Author");

            entity.HasIndex(e => e.Name, "IX_Author_Name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("Book");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAuthor).HasColumnName("idAuthor");
            entity.Property(e => e.IdCatalog).HasColumnName("idCatalog");
            entity.Property(e => e.IdPhoto).HasColumnName("idPhoto");
            entity.Property(e => e.IdSwap).HasColumnName("idSwap");
            entity.Property(e => e.IdTitle).HasColumnName("idTitle");
            entity.Property(e => e.IdUser).HasColumnName("idUser");

            entity.HasOne(d => d.IdAuthorNavigation).WithMany(p => p.Books).HasForeignKey(d => d.IdAuthor);

            entity.HasOne(d => d.IdCatalogNavigation).WithMany(p => p.Books).HasForeignKey(d => d.IdCatalog);

            entity.HasOne(d => d.IdPhotoNavigation).WithMany(p => p.Books).HasForeignKey(d => d.IdPhoto);

            entity.HasOne(d => d.IdSwapNavigation).WithMany(p => p.Books).HasForeignKey(d => d.IdSwap);

            entity.HasOne(d => d.IdTitleNavigation).WithMany(p => p.Books).HasForeignKey(d => d.IdTitle);

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Books).HasForeignKey(d => d.IdUser);
        });

        modelBuilder.Entity<Catalog>(entity =>
        {
            entity.ToTable("Catalog");

            entity.HasIndex(e => e.Category, "IX_Catalog_Category").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Galary>(entity =>
        {
            entity.ToTable("Galary");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Messenger>(entity =>
        {
            entity.HasIndex(e => e.Name, "IX_Messengers_Name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<OptionalPostponed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OptionalPostponed");

            entity.Property(e => e.IdBook).HasColumnName("idBook");
            entity.Property(e => e.IdUser).HasColumnName("idUser");

            entity.HasOne(d => d.IdBookNavigation).WithMany().HasForeignKey(d => d.IdBook);

            entity.HasOne(d => d.IdUserNavigation).WithMany().HasForeignKey(d => d.IdUser);
        });

        modelBuilder.Entity<PriceCategory>(entity =>
        {
            entity.ToTable("PriceCategory");

            entity.HasIndex(e => e.ValueToInt, "IX_PriceCategory_ValueToInt").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Swap>(entity =>
        {
            entity.ToTable("Swap");

            entity.HasIndex(e => e.Value, "IX_Swap_Value").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.ToTable("Title");

            entity.HasIndex(e => e.Title1, "IX_Title_title").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAutor).HasColumnName("idAutor");
            entity.Property(e => e.Title1).HasColumnName("title");

            entity.HasOne(d => d.IdAutorNavigation).WithMany(p => p.Titles).HasForeignKey(d => d.IdAutor);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => e.Telephone, "IX_User_telephone").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Pass).HasColumnName("pass");
            entity.Property(e => e.Telephone).HasColumnName("telephone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
