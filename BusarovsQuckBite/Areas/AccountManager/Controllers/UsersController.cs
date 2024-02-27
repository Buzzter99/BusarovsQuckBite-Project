using BusarovsQuckBite.Areas.AccountManager.Controllers;
using BusarovsQuckBite.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace BusarovsQuckBite.Areas.Users.Controllers
{
    [Area(AreaConstants.UserArea)]
    [Authorize]
    public class UsersController : BaseAdminController
    {

    }
}
