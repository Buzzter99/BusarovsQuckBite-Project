using BusarovsQuckBite.Models.Category;
using BusarovsQuickBite.Infrastructure.DataConstants;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BusarovsQuckBite.Models.Product
{
    public class ProductFormViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(DataConstants.ProductConstants.NameMinLength)]
        [MaxLength(DataConstants.ProductConstants.NameMaxLength)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MinLength(DataConstants.ProductConstants.DescriptionMinLength)]
        [MaxLength(DataConstants.ProductConstants.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int QtyAvailable { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public List<CategoryViewModel> ActiveCategories { get; set; } = new List<CategoryViewModel>();
        [Required]
        public IFormFile ImageFile { get; set; } = null!;
        public int ImageId { get; set; }
    }
}
