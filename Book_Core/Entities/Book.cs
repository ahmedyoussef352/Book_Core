namespace Book_Core.Entities;

public class Book
{
    public int Id { get; set; }
    public int ISBNNumber { get; set; } //Primary
    public string Title { get; set; }
    public decimal Price { get; set; }
    public int NumberOfPages { get; set; }
    public int PublishedYear { get; set; }
}

