using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Addresses.Models;

namespace Addresses.Data
{
    public partial class AddressesContext : DbContext
    {
        public AddressesContext()
        {
        }

        public AddressesContext(DbContextOptions<AddressesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.Housenumber).HasColumnName("housenumber");

                entity.Property(e => e.Street).HasColumnName("street");

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
