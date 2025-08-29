using Ef_3.Entities;
using Microsoft.EntityFrameworkCore;
namespace Ef_3.Context;

internal class Context: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-5566K3T;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Press> Presses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<TCard> TCards { get; set; }
    public DbSet<Lib> Libs { get; set; }
    public DbSet<SCard> SCards { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Faculty> Faculties { get; set; }

}
