using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGate.Infrastructure.Data.Models;
using TechGate.Infrastructure.Data;

namespace TechGate.Core.Models.Product
{
    public class ProductCardViewModel
    {


        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = string.Empty;



    }
}
