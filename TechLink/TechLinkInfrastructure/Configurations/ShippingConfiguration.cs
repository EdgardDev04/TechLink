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
    public class ShippingConfiguration : IEntityTypeConfiguration<Shipping>
    {
        public void Configure(EntityTypeBuilder<Shipping> builder)
        {
            builder.ToTable("Shippings");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Carrier);

            builder.Property(u => u.TrackingNumber);

            builder.Property(u => u.ShippedDate);

            builder.Property(u => u.EstimatedDelivery);

        }
    }
}
