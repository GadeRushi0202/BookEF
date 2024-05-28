using BookEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BookEF.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>db):base (db) { }

        public DbSet<Book>Books { get; set; }
    }
}
