using Book_Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Book_Core;

public class ReadMoreDbContext : DbContext
{
    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=ReadMoreBooksDb; Trusted_Connection=True; TrustServerCertificate=True");
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }


}
