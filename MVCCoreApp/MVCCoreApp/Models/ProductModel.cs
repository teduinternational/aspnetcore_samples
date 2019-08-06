using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Available { get; set; }
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }
    }
}
