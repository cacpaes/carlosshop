using CarlosShop.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarlosShop.Configurations
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<People> People { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<TypesReference> TypesReference { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=CarlosShop;Integrated Security=True; TrustServerCertificate=True;");
        }
    }

}
