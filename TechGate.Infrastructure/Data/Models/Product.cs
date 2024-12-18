
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TechGate.Infrastructure.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.Product.NameMaxLength)]  
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(DataConstants.Product.DescriptionMaxLength)]  
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(DataConstants.Product.ImageUrlMaxLength)]  
        public string ImageUrl { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }

        public int AmounInStock { get; set; }

        public ICollection<OrderItem> OrderItems { get; set;} = new List<OrderItem>();

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
