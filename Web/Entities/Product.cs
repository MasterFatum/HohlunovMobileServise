using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Entities
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
