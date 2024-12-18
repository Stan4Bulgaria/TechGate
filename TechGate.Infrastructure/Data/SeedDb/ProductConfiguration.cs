using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Infrastructure.Data.SeedDb
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasOne(c => c.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

          

            var data = new SeedData();

            builder.HasData(new Product[] 
            {
                data.RazerHeadPhones,
                data.RazerKeyboard,
                data.RazerMouse
            });
        }
    }
}
