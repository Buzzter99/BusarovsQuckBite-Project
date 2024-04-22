using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusarovsQuickBite.Core.Models.Administration
{
    public class AdministrationAllViewModel
    {
        public List<SelectListItem> FilterOptions { get; set; } = new List<SelectListItem>();
        public List<AdministrationViewModel> AdministrationDataModel { get; set; } = new List<AdministrationViewModel>();
    }
}
