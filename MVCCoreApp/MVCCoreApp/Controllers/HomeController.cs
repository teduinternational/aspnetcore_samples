using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Message = "Hello from Model, ID = " +id;
            return View(model);
        }
    }
}