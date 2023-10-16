using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityConfiguration
{
    public class ApartmentEntityConfiguration : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.ToTable("Apartment");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Section).HasMaxLength(50);
            builder.Property(p => p.Number).HasMaxLength(20);

            builder.HasOne(p => p.Building).WithMany(p => p.Apartments).HasForeignKey(k => k.BuildingId);
            builder.HasMany(p => p.Images).WithOne(p => p.Apartment).HasForeignKey(k => k.ApartmentId);
            builder.HasOne(p => p.Translation);
        }
    }
}
