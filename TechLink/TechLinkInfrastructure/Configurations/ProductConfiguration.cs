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
