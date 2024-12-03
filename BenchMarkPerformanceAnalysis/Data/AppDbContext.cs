using BenchMarkPerformanceAnalysis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMarkPerformanceAnalysis.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BAN-LAP-YEDDU;Database=Products; User Id=sa; Password=12345; Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; } // DbSet for Products
    }
}
