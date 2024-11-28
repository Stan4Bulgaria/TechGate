

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TechGate.Infrastructure.Data.Models
{
    public class User :IdentityUser
    {


        [Required]
        [MaxLength(DataConstants.User.ProfilePictureMaxLength, ErrorMessage = "Profile picture URL cannot exceed 255 characters.")]
        [Url(ErrorMessage = "Please provide a valid URL for the profile picture.")]
        public string ProfilePictureUrl { get; set; } = string.Empty;


        [Required]
        [MaxLength(DataConstants.User.AddressMaxLength, ErrorMessage = "Address cannot exceed 50 characters.")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        public ICollection<Order> Orders { get; set; } = new List<Order>();




    }
}
