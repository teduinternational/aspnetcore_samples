using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLayout.Models
{
    public class ProductEditModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        public Decimal Price { get; set; }
        public int Rating { get; set; }

        public List<Brand> Brands { get; set; }
        public List<Supplier> Suppliers { get; set; }

        public int BrandId { get; set; }
        public int SupplierId { get; set; }
    }
}
