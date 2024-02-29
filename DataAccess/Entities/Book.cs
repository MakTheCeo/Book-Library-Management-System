#nullable disable

public class Book
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public DateTime PublicationDate { get; set; }
    public int AuthorId { get; set; } // Foreign Key

    // Navigation properties
    public Author Author { get; set; }
    public ICollection<BorrowRecord> BorrowRecords { get; set; }
}
