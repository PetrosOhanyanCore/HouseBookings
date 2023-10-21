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
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Comment).HasMaxLength(350);

            builder.HasOne(p => p.Translation);

            builder.HasOne(p => p.Client)
                .WithMany(p => p.Scorings)
                .HasForeignKey(k => k.ClientId);

            builder.HasOne(p => p.Building)
                .WithMany(p => p.Scorings)
                .HasForeignKey(k => k.BuildingId);

            builder.HasOne(p => p.Apartment)
                .WithMany(p => p.Scorings)
                .HasForeignKey(k => k.ApartmentId);
        }
    }
}
