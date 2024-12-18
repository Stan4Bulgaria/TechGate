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
    internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasOne(p => p.Product)
                .WithMany(r => r.Reviews)
                .OnDelete(DeleteBehavior.Cascade);
                
           builder
                .HasOne(u => u.User)
                .WithMany(r => r.Reviews)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(data.ReviewOne);
        }
    }
}
