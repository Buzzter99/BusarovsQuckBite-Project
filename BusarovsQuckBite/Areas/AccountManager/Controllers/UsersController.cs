﻿using Microsoft.AspNetCore.Mvc;
using static BusarovsQuckBite.Constants.Constants;
namespace BusarovsQuckBite.Areas.Users.Controllers
{
    [Area(AreaConstants.UserArea)]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
