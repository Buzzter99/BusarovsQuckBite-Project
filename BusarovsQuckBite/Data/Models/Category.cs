using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusarovsQuckBite.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
        [Required]
        public string Who { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(Who))]
        public ApplicationUser User { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
