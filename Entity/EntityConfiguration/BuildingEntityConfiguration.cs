﻿using Microsoft.EntityFrameworkCore;
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

            builder.HasMany(b => b.BuildingImages)
                .WithOne(b => b.Building)
                .HasForeignKey(b => b.BuildingId);



            builder.HasMany(b => b.Apartments)
                .WithOne(b => b.Building)
                .HasForeignKey(a => a.BuildingId)
                .IsRequired();


            builder.HasOne(p => p.Location)
                .WithOne(b => b.Building)
                .HasForeignKey<Building>(p => p.LocationId);




        }
    }
}
