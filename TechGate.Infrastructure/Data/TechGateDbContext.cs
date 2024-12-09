using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechGate.Infrastructure.Data.Models;
using TechGate.Infrastructure.Data.SeedDb;

namespace TechGate.Data
{
    public class TechGateDbContext : IdentityDbContext
    {
        public DbSet<Category>? Categories { get; set; }

        public DbSet<Order>? Orders { get; set; }

        public DbSet<OrderItem>? OrderItems { get; set; }

        public DbSet<Payment>? Payments { get; set; }

        public DbSet<Product>? Products { get; set; }

        public DbSet<Review>? Reviews { get; set; }

        public DbSet<User>? ApplicationUser {  get; set; }

        public TechGateDbContext(DbContextOptions<TechGateDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderItemConfiguration());
            builder.ApplyConfiguration(new PaymentConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
