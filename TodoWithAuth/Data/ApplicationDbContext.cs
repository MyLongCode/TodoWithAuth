using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoWithAuth.Models;
namespace TodoWithAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Note> Notes{ get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}