using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Order")]

        public int OrderId { get; set; }
        [Required]
        [ForeignKey("Product")]

        public int ProductId { get; set; }
        [Required]
        [ForeignKey("Seller")]

        public string SelleBy { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string price { get; set; }
        
        [Required]
        public string Status { set; get; }
       
        public virtual Order Order { get; set; }


        public virtual Seller Seller { get; set; }

        public virtual Product Product { get; set; }



    }
}
