using System.Data.Entity;

namespace Models
{
    internal class AppDbContext : DbContext 
    {
        public AppDbContext() : base("DbConnection") { }
        public DbSet<Product> Products { get; set; }

    }
}
