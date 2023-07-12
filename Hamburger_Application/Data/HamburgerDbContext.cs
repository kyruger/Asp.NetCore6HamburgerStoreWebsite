using Hamburger_Application.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hamburger_Application.Data
{
    public class HamburgerDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public HamburgerDbContext(DbContextOptions<HamburgerDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRole> Roles { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Fries> Frieses { get; set; }
        public DbSet<Sauce> Hamburgers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sauce> Sauces { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(HamburgerDbContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}