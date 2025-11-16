using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BeFit.Data;


namespace BeFit.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BeFit.Models.ExType> ExType { get; set; } = default!;
        public DbSet<BeFit.Models.SessionInfo> SessionInfo { get; set; } = default!;
        public DbSet<BeFit.Models.ExConn> ExConn { get; set; } = default!;
    }
}
