using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.EntityConfiguration
{
    public class PaymentEntityConfiguartion : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payment");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.BookingId)
              .IsRequired();

            builder.Property(p => p.CurrencyCode)
              .IsRequired()
              .HasConversion(
                   v => v.ToString(),
                   v => (Currency)Enum.Parse(typeof(Currency), v)
               ); // Convert Enum to string and back

            builder.HasOne(p => p.Booking)
             .WithOne(b => b.Payment)
             .HasForeignKey<Payment>(p => p.BookingId); // one to one
        }
    }
}
