using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Entities;

namespace Web.Repository
{

    public class AdditionalMethods
    {
        Context context = new Context();

        public void SubtractCountProducts(int id)
        {
            Product newProduct = context.Products.Find(id);

            if (newProduct != null)
            {
                newProduct.ProductCount = newProduct.ProductCount - 1;
                context.SaveChanges();
            }
        }

        public void AddCountProducts(int id)
        {
            Product newProduct = context.Products.Find(id);

            if (newProduct != null)
            {
                newProduct.ProductCount = newProduct.ProductCount + 1;
                context.SaveChanges();
            }
        }
    }
}