using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Entities;
using Web.Repository;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        Context context = new Context();

        AdditionalMethods other = new AdditionalMethods();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Pays()
        {
            return View();
        }

        public ActionResult Delivery()
        {
            return View();
        }

        public ActionResult Main()
        {
            IEnumerable<Product> productses = context.Products.ToList().OrderBy(p => p.ProductName);

            ViewBag.CountProductsInBasket = context.FoodBasket.Count().ToString();

            return View(productses);
        }
        
        public ActionResult AddProductInFoodBasket(FoodBasket product)
        {
            if (product != null)
            {
                product.ProductCount = 1;

                product.TotalPrice = product.ProductPrice;

                context.FoodBasket.Add(product);

                context.SaveChanges();

                other.SubtractCountProducts(product.Id);
            }
            
            return RedirectToAction("Main");
        }

        public ActionResult SearchBook(string name)
        {
            IQueryable<Product> products = null;

            products = context.Products.Where(p => p.ProductName.Contains(name));

            if (products != null)
            {
                ViewBag.ProductsInList = products.Count();

                return View("SearchBook", products);
            }

            return RedirectToAction("Main");
        }
    }
}