using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Entities;
using Web.Models;
using Web.Repository;

namespace Web.Controllers
{
    public class FoodBasketController : Controller
    {
        Context context = new Context();

        AdditionalMethods other = new AdditionalMethods();
        public ActionResult Index()
        {
            try
            {
                IEnumerable<FoodBasket> foodBaskets = context.FoodBasket.ToList().OrderBy(b => b.ProductName);

                ViewBag.AllPrice = foodBaskets.Sum(p => p.TotalPrice);

                return View(foodBaskets);
            }
            catch (Exception)
            {
                return View();
            }
            
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            FoodBasket foodBasket = context.FoodBasket.FirstOrDefault(b => b.Id == id);

            if (foodBasket != null)
            {
                context.FoodBasket.Remove(foodBasket);

                context.SaveChanges();

                other.AddCountProducts(id);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult MakeOrder()
        {
            IEnumerable<FoodBasket> foodBaskets = context.FoodBasket.ToList().OrderBy(n => n.ProductName);

            ViewBag.DateNow = DateTime.Now.ToString();

            return View(foodBaskets as OrderViewModel);
        }

        [HttpPost]
        public ActionResult MakeOrder(Order order)
        {
            OrderViewModel orderViewModel = new OrderViewModel();

            return View("SuccessfulOrder", orderViewModel);
        }
    }
}
