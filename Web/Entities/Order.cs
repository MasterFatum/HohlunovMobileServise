using System;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;
using Label = System.Reflection.Emit.Label;

namespace Web.Entities
{
    public class Order
    {
        //Данные заказчика
        public int Id { get; set; }
        [Display(Name = "Фамилия")]
        public string Lastname { get; set; }
        [Display(Name = "Имя")]
        public string Firstname { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        //Данные заказа
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Date { get; set; }
    }
}