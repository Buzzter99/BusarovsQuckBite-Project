namespace BusarovsQuckBite.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int QtyAvailable { get; set; }
        public CategoryViewModel Category { get; set; } = null!;
        public string Creator { get; set; } = string.Empty;
        public string CreatedOn { get; set; } = string.Empty;
        public string ImageRelativePath { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public int QtyWanted { get; set; }

    }
}
