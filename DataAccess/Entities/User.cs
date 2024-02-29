#nullable disable

public class User
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; } 

    // For borrowing records
    public ICollection<BorrowRecord> BorrowRecords { get; set; }
}