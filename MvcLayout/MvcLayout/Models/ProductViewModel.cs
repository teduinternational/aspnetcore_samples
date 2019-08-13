using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLayout.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public Decimal Price { get; set; }
        public int Rating { get; set; }

        public string BrandName { get; set; }
        public string SupplierName { get; set; }

        public string GetRating()
        {
            if (Rating == 10)
            {
                return "*****";
            }
            else if (Rating >= 8)
            {
                return "****";
            }
            else if (Rating >= 6)
            {
                return "***";
            }
            else if (Rating >= 4)
            {
                return "**";
            }
            else
            {
                return "*";
            }
        }
    }
}
