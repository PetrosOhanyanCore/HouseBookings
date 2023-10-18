using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityConfiguration
{
    public class AddressEntityConfiguration:IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(x => x.Id);
            builder.Property(p=>p.Country).HasMaxLength(50);
            builder.Property(p=>p.City).HasMaxLength(50);
            builder.Property(p=>p.District).HasMaxLength(50);
            builder.Property(p=>p.Street).HasMaxLength(50);
        }
    }
}
