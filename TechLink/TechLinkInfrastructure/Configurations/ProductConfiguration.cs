using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechLink.Domain.Entities;
using TechLink.Domain.Enums;

namespace TechLink.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name);

            builder.Property(u => u.Brand);

            builder.Property(u => u.Image);

            builder.Property(u => u.Description);

            builder.Property(c => c.State)
                .HasConversion(
                v => v.ToString(),
                v => (StatusProduct)Enum.Parse(typeof(StatusProduct), v));

            builder.Property(c => c.Condition)
                .HasConversion(
                v => v.ToString(),
                v => (ConditionProduct)Enum.Parse(typeof(ConditionProduct), v));

            builder.Property(u => u.Price)
                .HasColumnType("decimal(18,2)");

            builder.Property(u => u.Stock);

            builder.HasOne(n => n.Category)
              .WithMany()
              .HasForeignKey(n => n.CategoryId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
