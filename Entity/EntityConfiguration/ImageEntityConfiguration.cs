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
    public class ImageEntityConfiguration : IEntityTypeConfiguration<Image<Type>>
    {
        public void Configure(EntityTypeBuilder<Image<Type>> builder)
        {
            builder.ToTable("Image");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ImageName).HasMaxLength(50);
            builder.Ignore(c => c.Property);
        }
    }
}