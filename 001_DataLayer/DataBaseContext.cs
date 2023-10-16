﻿using Entity;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ApartmentEntityConfiguration());

        }
    }
}