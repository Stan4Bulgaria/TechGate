using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGate.Core.Models
{
    public class ProductPageViewModel
    {
        public ICollection<ProductCardViewModel> Products { get; set; }
        public ICollection<CategoryViewModel> Categories { get; set; }
    }
}
