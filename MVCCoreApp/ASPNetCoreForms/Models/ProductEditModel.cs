using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ASPNetCoreForms.Models
{
    public class ProductEditModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(maximumLength:25,MinimumLength =3, ErrorMessage ="Length must be between 3 to 25")]
        public string Name { get; set; }
        public decimal? Rate { get; set; }

        [BindNever]
        public int Rating { get; set; }

        public DateTime CreatedDate { set; get; }
    }
}
