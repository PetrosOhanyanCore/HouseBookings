using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityConfiguration
{
    public class BuildingEntityConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.ToTable("Building");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.BuildingFloorQuantity)
                .IsRequired();

            builder.Property(p => p.BuildingHomeQuantity)
                .IsRequired();

            builder.Property(p => p.Images)
                .IsRequired();

            builder.HasMany(b => b.Images)
                .WithOne()
                .HasForeignKey(i => i.PropertyId)
                .IsRequired();


            builder.HasMany(b => b.Apartments)
                .WithOne()
                .HasForeignKey(a => a.BuildingId)
                .IsRequired();


            builder.HasOne(p => p.Location)
                .WithOne(b => b.Building)
                .HasForeignKey<Building>(p => p.LocationId);




        }
    }
}
