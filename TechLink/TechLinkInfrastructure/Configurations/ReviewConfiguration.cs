using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Infrastructure.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Comment);

            builder.Property(u => u.Rating);

            builder.Property(u => u.CreatedAt);

            builder.Property(u => u.CreatedAt);

            builder.HasOne(n => n.User)
              .WithMany()
              .HasForeignKey(n => n.UserId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(n => n.Product)
              .WithMany()
              .HasForeignKey(n => n.ProductId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
