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
    internal class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
           builder
                .HasOne(o => o.Order)
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(o => o.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

          builder 
                .HasOne(p => p.Product)
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(o => o.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            var data = new SeedData();

            builder.HasData(new OrderItem[] 
            {
                data.OrderItemOne,
                data.OrderItemTwo,
                data.OrderItemThree 
            });
        }
    }
}
