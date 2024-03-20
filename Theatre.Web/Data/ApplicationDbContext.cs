using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Theatre.Web.Models;

namespace Theatre.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Theatre.Web.Models.Ticket> Ticket { get; set; } = default!;
        public DbSet<Theatre.Web.Models.TheatreShow> TheatreShow { get; set; } = default!;
    }
}
