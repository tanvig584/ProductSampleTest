using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public int subCategoryId { get; set; }
        public int productTypeId { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public byte inStock { get; set; }
        public DateTime startDate { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}