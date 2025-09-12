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
    public class WishListProductConfiguration : IEntityTypeConfiguration<WishListProduct>
    {
        public void Configure(EntityTypeBuilder<WishListProduct> builder)
        {
            builder.ToTable("WishListProduct");

            builder.HasKey(wp => new { wp.WishListId, wp.ProductId });

            builder.HasOne(wp => wp.WishList)
                   .WithMany(w => w.WishListProducts)
                   .HasForeignKey(wp => wp.WishListId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(wp => wp.Product)
                   .WithMany()
                   .HasForeignKey(wp => wp.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
