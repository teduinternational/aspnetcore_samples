using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return "Hello from Index method of Admin Controller";
        }
    }
}