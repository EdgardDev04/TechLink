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
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.ToTable("CartItems");
            builder.HasKey(u => u.Id);

            builder.Property(c => c.Quantity);

            builder.HasOne(n => n.Cart)
              .WithMany()
              .HasForeignKey(n => n.CartId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(n => n.Product)
              .WithMany()
              .HasForeignKey(n => n.ProductId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
