using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechLink.Domain.Entities;

namespace TechLink.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.UserName);

            builder.Property(u => u.ImageProfile);

            builder.Property(u => u.Email);

            builder.Property(u => u.Password);

            builder.Property(u => u.RegisteredAt);

            builder.Property(u => u.LastLogin);

            builder.HasMany(u => u.Addresses)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

           builder.HasOne(u => u.Role)
                .WithOne(r => r.User)
                .HasForeignKey<Role>(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
