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
    internal class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
           

            builder
                .HasOne(u => u.User)
                .WithMany(p => p.Payments)
                .OnDelete(DeleteBehavior.Restrict);


            var data = new SeedData();
            builder.HasData(new Payment[] 
            {
                data.PaymentOne,
                data.PaymentTwo,
            });

        }
    }
}
