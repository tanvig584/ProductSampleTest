using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductsApp.Models
{
    public class ProductCategory
    {
        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }
}