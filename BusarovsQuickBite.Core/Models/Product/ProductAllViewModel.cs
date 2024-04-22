using BusarovsQuickBite.Core.Models.Category;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusarovsQuickBite.Core.Models.Product
{
    public class ProductAllViewModel
    {
        public List<CategoryViewModel> CategoriesWithProducts { get; set; } = new List<CategoryViewModel>();
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
        public List<SelectListItem> FilterOptions { get; set; } = new List<SelectListItem>();
    }
}
