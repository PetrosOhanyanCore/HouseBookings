using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.EntityConfiguration
{
    public class BuildingImageEntityConfiguration : IEntityTypeConfiguration<BuildingImage>
    {
        public void Configure(EntityTypeBuilder<BuildingImage> builder)
        {
            builder.ToTable("BuildingImage");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ImageName).IsRequired();


            builder.HasOne(p => p.Building)
              .WithMany(p => p.BuildingImages)
              .HasForeignKey(k => k.BuildingId);


        }
    }
}
