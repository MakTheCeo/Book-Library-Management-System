using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<BorrowRecord> BorrowRecords { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure one-to-many relationship between Author and Books
        modelBuilder.Entity<Author>()
            .HasMany(a => a.Books)
            .WithOne(b => b.Author)
            .HasForeignKey(b => b.AuthorId);

        // Configure one-to-many relationship between Book and BorrowRecords
        modelBuilder.Entity<Book>()
            .HasMany(b => b.BorrowRecords)
            .WithOne(br => br.Book)
            .HasForeignKey(br => br.BookId);

        // Configure one-to-many relationship between User and BorrowRecords
        modelBuilder.Entity<User>()
            .HasMany(u => u.BorrowRecords)
            .WithOne(br => br.User)
            .HasForeignKey(br => br.UserId);

    }
}
