﻿using Microsoft.AspNetCore.Mvc;

namespace TechLink.Presentation.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
