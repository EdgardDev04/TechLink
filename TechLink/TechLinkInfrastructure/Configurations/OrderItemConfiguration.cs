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
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Quantity);

            builder.Property(u => u.UnitPrice)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(n => n.Product)
              .WithMany()
              .HasForeignKey(n => n.ProductId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(n => n.Order)
              .WithMany()
              .HasForeignKey(n => n.OrderId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
