using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        //[Route("Home/Index/{id:int}")]
        public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Message = "Hello from Model, ID = " + id;
            return View(model);
        }

        //public IActionResult Index(int year)
        //{
        //    var model = new IndexModel();
        //    model.Message = "Hello from Model, Year = " + year;
        //    return View(model);
        //}

        //public IActionResult Index(string id)
        //{
        //    var model = new IndexModel();
        //    model.Message = "Hello from Model, Year = " + id;
        //    return View(model);
        //}

        //public IActionResult Index(int id)
        //{
        //    if (id == 0)
        //        return NotFound();

        //    return Content("Hello");
        //}
    }
}