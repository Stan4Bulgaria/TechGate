

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGate.Infrastructure.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }


        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }


        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        public DataConstants.OrderStatus OrderStatus { get; set; }

        [Required]
        [MaxLength(DataConstants.Order.ShippingAddressMaxLength)]
        public string ShippingAddress { get; set; } = string.Empty;

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
