﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreForms.Models
{
    public class ProductEditModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public decimal? Rate { get; set; }
        public int Rating { get; set; }

        public DateTime CreatedDate { set; get; }
    }
}
