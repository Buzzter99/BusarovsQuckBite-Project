using BusarovsQuickBite.Core.Models.Product;

namespace BusarovsQuickBite.Core.Models.Cart
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public string CartOwner { get; set; } = string.Empty;
        public List<ProductViewModel> ProductAll { get; set; } = new List<ProductViewModel>();
    }
}
