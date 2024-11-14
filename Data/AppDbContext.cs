using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.Models;
using CordiSimpleDotnet.Seeders;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleDotnet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<User>() // Unique restriction for user email in database
                .HasIndex(u => u.Email)
                .IsUnique();

            // Seeders
            UserSeeders.Seed(modelBuilder);
            EventSeeders.Seed(modelBuilder);
        }
    }
}