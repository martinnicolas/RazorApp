using Microsoft.EntityFrameworkCore;

namespace RazorApp.Models
{
    public class RazorAppContext : DbContext
    {
        public RazorAppContext (DbContextOptions<RazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorApp.Models.Persona> Persona { get; set; }
    }
}