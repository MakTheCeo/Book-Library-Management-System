#nullable disable

using DataAccess.Records.Bases;

public class Author : Record
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Biography { get; set; }

    // Navigation property
    public ICollection<Book> Books { get; set; }
}
