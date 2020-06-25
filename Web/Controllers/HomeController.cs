using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        Context context = new Context();

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
            IEnumerable<Products> productses = context.Products.ToList().OrderBy(p => p.ProductName);

            return View(productses);
        }

        public ActionResult AddInFoodBasket()
        {
            return RedirectToAction("Main");
        }
    }
}