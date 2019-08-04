using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="กรุณาระบุชื่อสินค้า")]
        [Display(Name ="ชื่อสินค้า")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "กรุณาระบุราคาสินค้า")]
        [Display(Name ="ราคาสินค้า")]
        public float ProductPrice { get; set; }

        [Required(ErrorMessage = "กรุณาระบุจำนวนสินค้า")]
        [Display(Name ="จำนวนสินค้า")]
        public int ProductAmount { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, float price, int amount)
        {
            ProductId = id;
            ProductName = name;
            ProductPrice = price;
            ProductAmount = amount;
        }
    }
}