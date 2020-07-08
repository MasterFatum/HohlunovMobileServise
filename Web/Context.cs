using Web.Entities;
using System.Data.Entity;

namespace Web
{
    

    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public  DbSet<FoodBasket> FoodBasket { get; set; }
        public  DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
