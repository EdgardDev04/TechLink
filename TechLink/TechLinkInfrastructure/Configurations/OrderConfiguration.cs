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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(u => u.Id);

            builder.Property(c => c.Status)
                  .HasConversion(
                  v => v.ToString(),
                  v => (StatusOrder)Enum.Parse(typeof(StatusOrder), v));

            builder.Property(u => u.OrderDate);

            builder.Property(u => u.TotalAmount)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(n => n.User)
              .WithMany()
              .HasForeignKey(n => n.UserId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(n => n.Coupon)
              .WithMany()
              .HasForeignKey(n => n.CouponId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(n => n.Shipping)
              .WithMany()
              .HasForeignKey(n => n.ShippingId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
