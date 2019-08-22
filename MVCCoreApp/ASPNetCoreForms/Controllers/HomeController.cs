using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreForms.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreForms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        public IActionResult Edit()
        {
            var model = new ProductEditModel();
            model.Name = "test";
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "Product: " + model.Name + ". Rate: "
                          + model.Rate + ". Rating: " + model.Rating + " created successfully";
            }
            else
            {
                message = "Failed to create the product. Please try again.";
            }
            return Content(message);
        }
    }
}