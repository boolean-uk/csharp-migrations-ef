using csharp_migrations_ef.Main.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_migrations_ef.Main.data
{
    public class DataContext : DbContext
    {
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["postgreSQL"].ToString());

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeesInProject>().HasKey(e => new { e.EmployeeID, e.ProjectID });
            modelBuilder.Seed();

        }
    }
}
