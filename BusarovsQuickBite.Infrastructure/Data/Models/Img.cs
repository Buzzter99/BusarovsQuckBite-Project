using System.ComponentModel.DataAnnotations;
using BusarovsQuickBite.Infrastructure.DataConstants;

namespace BusarovsQuckBite.Data.Models
{
    public class Img
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(DataConstants.ImgConstants.NameMaxLength)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.ImgConstants.FullPathMaxLength)]
        public string FullPath { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.ImgConstants.RelativePathMaxLength)]
        public string RelativePath { get; set; } = string.Empty;
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
