using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.DAL
{
    public class SalesSystemDbContext : DbContext
    {
        public const string DatabaseName = "SalesSystemDatabaseName";


        /// <summary>Default ctor for testing in-memory database
        /// </summary>
        public SalesSystemDbContext()
        {
        }

        public SalesSystemDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseInMemoryDatabase(DatabaseName);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
