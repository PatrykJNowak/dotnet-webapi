using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapp.Models
{
    public class Context : DbContext
    {
        public DbSet<Contact> Contact { get; set; }
        public DbSet<SellData> SellData { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BS68BQ4;Database=dontnet-webapi;Trusted_Connection=True;");
        }
    }
}