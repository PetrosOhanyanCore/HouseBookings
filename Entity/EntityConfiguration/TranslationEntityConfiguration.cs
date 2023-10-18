using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityConfiguration
{
    public class TranslationEntityConfiguration : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {
            builder.ToTable("Translation");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Arm).HasMaxLength(5000);
            builder.Property(p => p.Rus).HasMaxLength(5000);
            builder.Property(p => p.En).HasMaxLength(5000);
            
           
        }
    }
}