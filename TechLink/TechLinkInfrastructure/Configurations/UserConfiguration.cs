using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TechLink.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.UserName);

            builder.Property(u => u.Email);

            builder.Property(u => u.Password);

            builder.Property(u => u.RegisteredAt);

            builder.Property(u => u.IsActive);

            builder.Property(u => u.EmailConfirmed);

            builder.Property(u => u.LastLogin);

            builder.HasOne(n => n.Role)
              .WithMany()
              .HasForeignKey(n => n.RoleId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(n => n.Customer)
              .WithMany()
              .HasForeignKey(n => n.CustomerId)
              .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
