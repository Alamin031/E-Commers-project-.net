using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public  class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(15)]
        public string ProductCategory {get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [Required]
        public int ProdcutQuantity { get; set; }
        [ForeignKey("Seller")]
        public string SelleingBy { get; set; }

        public virtual Seller Seller { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual ICollection<Order> Orders { get; set; }


        public Product()
        {
            Orders = new List<Order>();
            ProductOrders = new List<ProductOrder>();
            Carts = new List<Cart>();
            Reviews = new List<Review>();
        }
    }
}