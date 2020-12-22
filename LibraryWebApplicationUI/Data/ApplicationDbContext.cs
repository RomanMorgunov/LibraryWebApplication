using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LibraryWebApplicationUI.Models;

namespace LibraryWebApplicationUI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Book> Books { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Authors)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);
                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.CoverImage)
                    .IsRequired();
                entity.Property(e => e.File)
                    .IsRequired();
            });

            base.OnModelCreating(builder);
        }
    }
}
