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
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            var data = new SeedData();
            builder.HasData(new Order[] 
            { 
                data.QuestOneOrder, data.QuestTwoOrder 
            });
        }
    }
}
