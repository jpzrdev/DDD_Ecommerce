using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class ContextBase : IdentityDbContext<IdentityUser>
    {
        public ContextBase() { }
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) { }

        public DbSet<Product> Product { get; set; }
        public DbSet<UserOrder> UserOrder { get; set; }
        public DbSet<IdentityUser> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
            base.OnModelCreating(builder);
        }
        private string GetConnectionString()
        {
            // var conStr = "Server=localhost\\SQLEXPRESS;Database=EcommerceDB;Trusted_Connection=True;providerName=System.Data.SqlClient";
            var conStr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EcommerceDB;Trusted_Connection=True;";
            return conStr;
        }

    }
}