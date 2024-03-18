using System.ComponentModel.DataAnnotations;
using BusarovsQuckBite.Data.Models;

namespace BusarovsQuckBite.Models
{
    public class ProductViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int QtyAvailable { get; set; }
        [Required]
        public CategoryViewModel Category { get; set; } = null!;
        [Required]
        public string Creator { get; set; } = string.Empty;
        [Required]
        public string CreatedOn { get; set; } = string.Empty;
        public string ImageRelativePath { get; set; } = string.Empty;
        public List<CategoryViewModel> CategoriesWithProducts { get; set; } = new List<CategoryViewModel>();

    }
}
