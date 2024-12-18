using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TechGate.Infrastructure.Data;
using TechGate.Core.ErrorMessages;


namespace TechGate.Core.Models
{
    public class AddProductFormViewModel
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(DataConstants.Product.NameMaxLength)]
        [MinLength(DataConstants.Product.NameMinLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.Product.DescriptionMaxLength)]
        [MinLength(DataConstants.Product.DescriptionMinLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(DataConstants.Product.PriceMinValue, DataConstants.Product.PriceMaxValue, ErrorMessage = ValidationMessages.InvalidPrice)]
        public decimal Price { get; set; }

        [Required]
        [Url]
        [MaxLength(DataConstants.Product.ImageUrlMaxLength)]
        [MinLength(DataConstants.Product.ImageUrlMinLength)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }

        [Required]
        [Range(DataConstants.Product.InStockMinAmount, DataConstants.Product.InStocMaxAmount, ErrorMessage = ValidationMessages.InvalidAmount)]
        public int AmountInStock { get; set; }





    }
}
