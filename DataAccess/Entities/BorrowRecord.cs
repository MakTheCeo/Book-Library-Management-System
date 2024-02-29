#nullable disable

public class BorrowRecord
{
    public int BookId { get; set; }
    public int UserId { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; } // Nullable for books that haven't been returned yet

    // Navigation properties
    public Book Book { get; set; }
    public User User { get; set; }
}
