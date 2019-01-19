using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ProductsApp.Models
{
    public class ProductSubCategory
    {
        [Key]
        public int subCategoryId { get; set; }
        public int categoryId { get; set; }
        public string subCategoryName { get; set; }
    }
}