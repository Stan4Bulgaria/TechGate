using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGate.Infrastructure.Data.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }  
        [ForeignKey(nameof(OrderId))]
        public Order? Order { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty; 
        [ForeignKey(nameof(UserId))]
        public User? User { get; set; } 

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get; set; } 

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public DataConstants.PaymentMethod PaymentMethod {  get; set; }

        public DataConstants.PaymentStatus PaymentStatus { get; set; }  

    }
}
