namespace BusarovsQuckBite.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TransactionDateAndTime { get; set; } = string.Empty;
        public string Creator { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
    }
}
