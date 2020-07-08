using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Entities;

namespace Web.Models
{
    public class OrderViewModel
    {
        public List<FoodBasket> foodBaskets = new List<FoodBasket>();
        public Order Order { get; set; }

    }
}