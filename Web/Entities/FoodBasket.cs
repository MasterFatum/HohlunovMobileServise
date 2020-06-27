namespace Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodBasket")]
    public class FoodBasket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
