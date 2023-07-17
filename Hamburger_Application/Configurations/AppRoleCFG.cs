using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class AppRoleCfg : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData
                (
                new AppRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new AppRole { Id = 2, Name = "User", NormalizedName = "USER" }
                );
        }
    }
}
