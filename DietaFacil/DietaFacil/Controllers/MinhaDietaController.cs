﻿using Microsoft.AspNetCore.Mvc;

namespace DietaFacil.Controllers
{
    public class MinhaDietaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
