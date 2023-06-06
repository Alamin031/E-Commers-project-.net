using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public  class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderType { get; set; }
        [Required]
        public string OrderQuantity { get; set; }

        [Required]
        public string Location { get; set; }

        [ForeignKey("Seller")]
        public string SelleBy { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public  virtual Seller Seller { get; set; }
        public  virtual Product Product { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<orderinformation> orderinformationsS { get; set; }
        public virtual ICollection<DeliveryManReview> Orders { get; set; }


        public Order ()
        {
            Products = new List<Product>();
            OrderDetails = new List<OrderDetails>();
            orderinformationsS = new List<orderinformation>();
            Orders = new List<DeliveryManReview>();
        }
    }
}