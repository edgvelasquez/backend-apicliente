using apiCliente.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace apiCliente.Configuration
{
    public class DBContextConfiguration:DbContext
    {
        public DBContextConfiguration(DbContextOptions<DBContextConfiguration> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
    }
}
