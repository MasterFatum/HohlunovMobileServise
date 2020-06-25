namespace Web
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public  DbSet<FoodBasket> FoodBasket { get; set; }
        public  DbSet<Products> Products { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<FoodBasket>()
        //        .Property(e => e.ProductPrice)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FoodBasket>()
        //        .Property(e => e.TotalPrice)
        //        .IsFixedLength();

        //    modelBuilder.Entity<Products>()
        //        .Property(e => e.ProductPrice)
        //        .HasPrecision(18, 0);
        //}
    }
}
