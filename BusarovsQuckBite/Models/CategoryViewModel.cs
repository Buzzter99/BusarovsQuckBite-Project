using System.ComponentModel.DataAnnotations;
using BusarovsQuckBite.Constants;

namespace BusarovsQuckBite.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(DataConstants.CategoryConstants.CategoryMinLength)]
        [MaxLength(DataConstants.CategoryConstants.CategoryMaxLength)]
        public string Name { get; set; } = string.Empty;
        public string TransactionDateAndTime { get; set; } = string.Empty;
        public string Creator { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
    }
}
