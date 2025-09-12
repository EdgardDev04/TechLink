using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechLink.Domain.Entities;

namespace TechLink.Infrastructure.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable("Notifications");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Message);

            builder.Property(u => u.IsRead);

            builder.Property(u => u.SentAt);

            builder.HasOne(n => n.User)
              .WithOne()
              .HasForeignKey<Notification>(n => n.UserId)
              .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
