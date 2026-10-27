namespace Book_Core.Entities;

public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string ShortBiography { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Age { get; set; }

}
