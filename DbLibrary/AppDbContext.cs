using System.Data.Entity;
using DbLibrary.Models;

namespace DbLibrary
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext() : base("MyDb") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Check> Checks { get; set; }
        
    }
}
