using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _0810.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DateNow = DateTime.Now.Year;
            return View();
        }
    }
}