using Microsoft.EntityFrameworkCore;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Persistance.Context
{
    public class UdemyJwtContext : DbContext
    {
        public UdemyJwtContext(DbContextOptions<UdemyJwtContext> options) : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<AppUser> AppUsers => Set<AppUser>();
        public DbSet<AppRole> AppRoles => Set<AppRole>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
