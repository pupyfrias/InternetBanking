using InternetBanking.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternetBanking.Infrastructure.Identity.Contexts
{
    public class IdentityContext: IdentityDbContext<ApplicationUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");
            builder.Entity<ApplicationUser>(entity => entity.ToTable("User"));
            builder.Entity<IdentityRole>(entity => entity.ToTable("Role"));
            builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable("UserRole"));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable("UserLogin"));

        }
    }
}
