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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Amount);

            builder.Property(u => u.PaymentMethod);

            builder.Property(u => u.PaidAt);

            builder.Property(u => u.IsSuccessful);

            builder.HasOne(n => n.Order)
              .WithMany()
              .HasForeignKey(n => n.OrderId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
