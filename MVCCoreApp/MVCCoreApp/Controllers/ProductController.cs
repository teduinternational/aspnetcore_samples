using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //Fail: http://localhost:6001/product/edit
        //Ok: http://localhost:6001/product/modify
        //[ActionName("modify")]
        //[Route("Product/Modify")]
        //[NonAction]
        [HttpGet]
        public string Edit(string id)
        {
            return "Hello from edit method";
        }

        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {
            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return new List<ProductModel>();
        }

        //GET: product/test
        [HttpGet("{id}")]
        public List<ProductModel> GetById(string id)
        {
            return new List<ProductModel>();
        }

        //POST: product
        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
           //TODO: Create a product in DB
           return Ok();
        }

        //PUT: product/10
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody]ProductModel product)
        {
            //TODO: Create a product in DB
            return Ok();
        }

        //DELETE: product/10
        [HttpDelete("{id}")]
        public IActionResult Update(string id)
        {
            //TODO: Create a product in DB
            return Ok();
        }


    }
}