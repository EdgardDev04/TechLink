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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(u => u.Id);

            builder.Property(c => c.Street);

            builder.Property(c => c.City);

            builder.Property(c => c.StateOrProvince);

            builder.Property(c => c.PostalCode);

            builder.Property(c => c.Country);

            builder.HasOne(r => r.User)
                .WithMany(u => u.Addresses) 
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
