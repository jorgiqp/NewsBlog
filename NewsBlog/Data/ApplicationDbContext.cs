using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsBlog.Models;

namespace NewsBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NewsBlog.Models.User>? User { get; set; }
        public DbSet<NewsBlog.Models.Role>? Role { get; set; }
    }
}