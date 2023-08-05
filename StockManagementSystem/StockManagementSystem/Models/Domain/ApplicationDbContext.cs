﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Reflection.Emit;

namespace StockManagementSystem.Models.Domain
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts):base(opts)
        {
           
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Company>().
                HasMany(i => i.Items).
                WithOne(m => m.Company).
                HasForeignKey(e => e.CompanyID).
                IsRequired();

          builder.Entity<Category>().
             HasMany(i => i.Items).
             WithOne(m => m.Category).
             HasForeignKey(e => e.CategoryId).
            IsRequired();

            builder.Entity<Item>()
            .HasIndex(e => e.Name)
            .IsUnique();
            builder.Entity<Category>()
               .HasIndex(e => e.Name)
            .IsUnique();

            builder.Entity<Company>()
             .HasIndex(e => e.Name)
          .IsUnique();





        }

    }
}
