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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[]
            {

                 new Category { Id = data.HeadPhoneCategory.Id, Name = data.HeadPhoneCategory.Name },
                 new Category { Id = data.EarBudCategory.Id, Name = data.EarBudCategory.Name },
                 new Category { Id = data.KeyboardCategory.Id, Name = data.KeyboardCategory.Name },
                 new Category { Id = data.MouseCategory.Id, Name = data.MouseCategory.Name },
                 new Category { Id = data.MonitorCategory.Id, Name = data.MonitorCategory.Name },
                 new Category { Id = data.SpeakerCategory.Id, Name = data.SpeakerCategory.Name },
                 new Category { Id = data.PadCategory.Id, Name = data.PadCategory.Name },
                 new Category { Id = data.GamingChairCategory.Id, Name = data.GamingChairCategory.Name }

            });
        }
    }
}
