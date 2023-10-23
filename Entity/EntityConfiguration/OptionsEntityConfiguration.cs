using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityConfiguration
{
    public class OptionsEntityConfiguration : IEntityTypeConfiguration<Options>
    {
        public void Configure(EntityTypeBuilder<Options> builder)
        {
            builder.ToTable("Options");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Discription).HasMaxLength(500);

            builder.HasOne(p => p.Building)
                .WithMany(p => p.Options)
                .HasForeignKey(k => k.BuildingId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.Apartment)
                .WithMany(p => p.Options)
                .HasForeignKey(k => k.ApartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
