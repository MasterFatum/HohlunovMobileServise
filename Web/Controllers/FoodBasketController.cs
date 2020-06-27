using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class FoodBasketController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            IEnumerable<FoodBasket> foodBaskets = context.FoodBasket.ToList().OrderBy(b => b.ProductName);

            return View(foodBaskets);
        }

        // GET: FoodBasket/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodBasket/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodBasket/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodBasket/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodBasket/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodBasket/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodBasket/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
