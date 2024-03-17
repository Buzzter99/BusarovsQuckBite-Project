using System.ComponentModel.DataAnnotations;

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
        public List<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
        [Required]
        public string Creator { get; set; } = string.Empty;
        [Required]
        public string ImageFullPath { get; set; } = string.Empty;

    }
}
