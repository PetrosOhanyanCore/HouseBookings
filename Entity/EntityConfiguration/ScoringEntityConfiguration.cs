using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityConfiguration
{
    public class ScoringEntityConfiguration : IEntityTypeConfiguration<Scoring>
    {
        public void Configure(EntityTypeBuilder<Scoring> builder)
        {
            builder.ToTable("Scoring");
            builder.HasKey(i => i.Id);
            builder.Property(p => p.Comment).HasMaxLength(400);
           
            
        }
    }
}
