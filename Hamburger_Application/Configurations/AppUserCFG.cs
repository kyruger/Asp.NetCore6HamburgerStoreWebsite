﻿using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class AppUserCFG : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(b => b.FirstName).HasMaxLength(30);
            builder.Property(b => b.LastName).HasMaxLength(30);
            builder.Property(b => b.Email).HasMaxLength(50);
            builder.Property(b => b.Address).HasMaxLength(200);
            builder.Property(b => b.Email).IsRequired();
            builder.HasIndex(b => b.Email).IsUnique();
        }
    }
}
