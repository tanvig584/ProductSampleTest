using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductsApp.Models;

namespace ProductsApp.ViewModel
{
    public class ProductsListViewModel
    {
        public Product products { get; set; }
        public ProductCategory category { get; set; }
        public ProductSubCategory subcategory { get; set; }
    }
}