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
            builder.HasForeignKey(c => c.ClientId);
            builder.HasForeignKey(b => b.ApartmentId);
            builder.Property(b => b.BookingEndDate).IsRequired();
            builder.Property(b => b.CancelationReason).HasConversion<int?>();
            builder.Property(b => b.CancelationReason).IsRequired(false);
            builder.Property(b => b.CancelationDate).IsRequired(false);




        }
    }
}
