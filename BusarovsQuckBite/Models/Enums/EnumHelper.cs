using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusarovsQuckBite.Models.Enums
{
    public class EnumHelper
    {
        public static List<SelectListItem> GetEnumSelectList<TEnum>() where TEnum : struct
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .Select(e => new SelectListItem
                {
                    Value = e.ToString(),
                    Text = e.ToString()
                })
                .ToList();
        }
    }
}
