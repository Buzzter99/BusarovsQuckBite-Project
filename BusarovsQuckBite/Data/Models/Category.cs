using System.ComponentModel.DataAnnotations;

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
        public DateTime? LastModifiedOn { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
