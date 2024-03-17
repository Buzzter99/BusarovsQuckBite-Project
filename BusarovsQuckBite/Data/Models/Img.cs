using System.ComponentModel.DataAnnotations;
using BusarovsQuckBite.Constants;

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
    }
}
