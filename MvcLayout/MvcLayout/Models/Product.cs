using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLayout.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public Decimal Price { get; set; }
        public int Rating { get; set; }

        public Brand Brand { get; set; }
        public Supplier Supplier { get; set; }
    }
}
