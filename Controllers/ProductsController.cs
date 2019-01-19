using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductsApp.Models;
using ProductsApp.ViewModel;

namespace ProductsApp.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult ProductList(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                var viewModel =
                          from pd in _context.Product
                          join psc in _context.ProductSubCategory on pd.subCategoryId equals psc.subCategoryId
                          join pc in _context.ProductCategory on psc.categoryId equals pc.categoryId
                          select new ProductsListViewModel { products = pd, category = pc, subcategory = psc };

                return View(viewModel);
            }
            else
            {
                var viewModel =
                          from pd in _context.Product
                          join psc in _context.ProductSubCategory on pd.subCategoryId equals psc.subCategoryId
                          join pc in _context.ProductCategory on psc.categoryId equals pc.categoryId
                          where pc.categoryName == searchString
                          select new ProductsListViewModel { products = pd, category = pc, subcategory = psc };
                return View(viewModel);

            }
        }
 
        public ActionResult CreateProduct()
        {
           
             return View();
        }
        [HttpPost]
        public ActionResult SaveProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
            return RedirectToAction("ProductList","Products");
        }
    }
}