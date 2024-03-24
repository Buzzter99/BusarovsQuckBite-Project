using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusarovsQuckBite.Areas.AccountManager.Models
{
    public class AdministrationAllViewModel
    {
        public List<SelectListItem> FilterOptions { get; set; } = new List<SelectListItem>();
        public List<AdministrationViewModel> AdministrationDataModel { get; set; } = new List<AdministrationViewModel>();
    }
}
