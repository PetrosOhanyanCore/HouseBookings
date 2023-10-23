using Entity;
using Entity.EntityConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataBaseContext : IdentityDbContext<ApplicationUser>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {

        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Scoring> Scorings { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ApartmentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BuildingEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ScoringEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OptionsEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TranslationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BuildingEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentEntityConfiguartion());
            modelBuilder.ApplyConfiguration(new ClientEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ImageEntityConfiguration());

        }
    }
}
