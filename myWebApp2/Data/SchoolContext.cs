using Microsoft.EntityFrameworkCore;
using myWebApp2.Models;

namespace myWebApp2.Data;

public class SchoolContext : DbContext
{
    public SchoolContext (DbContextOptions<SchoolContext> options)
        : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
}