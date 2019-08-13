using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Greeting"] = "Hello world";
            ViewBag.Product = new ProductModel()
            {
                Id=1,
                Name = "TEDU",
                Brand = "TEDU",
                Price = 1000
            };
            return View();
        }
    }
}