

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGate.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }
   

        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        
        public int Rating { get; set; }

        [MaxLength(DataConstants.Review.CommentMaxLength)]
        public string Comment { get; set; } = string.Empty;
      
        public DateTime CreatedAt { get; set; }  
    }
}
