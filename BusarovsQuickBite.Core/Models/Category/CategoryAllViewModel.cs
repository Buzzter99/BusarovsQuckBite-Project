using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusarovsQuickBite.Core.Models.Category
{
    public class CategoryAllViewModel
    {
        public List<CategoryViewModel> CategoryViewModel { get; set; } = null!;
        public List<SelectListItem> CategoryCriteria { get; set; } = null!;
    }
}
