using BusarovsQuckBite.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Areas.AccountManager.Controllers
{
    [Authorize]
    [Area(AreaConstants.UserArea)]
    public abstract class BaseAreaController : Controller
    {
        
    }
}
