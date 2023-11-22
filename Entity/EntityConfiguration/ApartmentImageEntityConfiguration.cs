using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Entity.EntityConfiguration
    
{
    //Apartment
    public class ApartmentImageEntityConfiguration : IEntityTypeConfiguration<ApartmentImage>
    {
        public void Configure(EntityTypeBuilder<ApartmentImage> builder)
        {
            builder.ToTable("ApartmentImage");
            builder.HasKey(c => c.Id);
            builder.HasAlternateKey(c => c.ApartmentId);
            builder.Property(c => c.ImageName).HasMaxLength(50);


            builder.HasOne(p => p.Apartment)
         .WithMany(p => p.ApartmentImages)
         .HasForeignKey(k => k.ApartmentId);

        }
    }
}