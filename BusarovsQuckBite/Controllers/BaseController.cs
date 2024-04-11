using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        
    }
}
