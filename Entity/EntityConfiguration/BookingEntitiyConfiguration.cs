using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityConfiguration
{
    internal class BookingEntitiyConfiguration : IEntityTypeConfiguration<Booking>
    {

        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Booking");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Note).HasMaxLength(200);
            builder.HasOne(p => p.Booking).WithOne(p => p.Client).HasForeignKey(p => p.ClientId);
            builder.HasOne(p =>p.Booking).WithOne(p => p.Apartment).HasForeignKey(p => p.ApartmentId);



        }
    }
}
