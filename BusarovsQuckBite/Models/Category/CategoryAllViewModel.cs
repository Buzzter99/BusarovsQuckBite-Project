using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusarovsQuckBite.Models.Category
{
    public class CategoryAllViewModel
    {
        public List<CategoryViewModel> CategoryViewModel { get; set; } = null!;
        public List<SelectListItem> CategoryCriteria { get; set; } = null!;
    }
}
