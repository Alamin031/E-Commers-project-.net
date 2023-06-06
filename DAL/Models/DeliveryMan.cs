using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DeliveryMan
    {
        [Key]
        public string Uname { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        public virtual ICollection<ReciveProduct> ReciveProducts { get; set; }
        public virtual ICollection<orderinformation> orderinformations { get; set; }
        public virtual ICollection<DeliveryManReview> DeliveryManReviews { get; set; }
        public virtual ICollection<AssignProduct> AssignProducts { get; set; }
        public virtual ICollection<Delivery_Location_Msg> Delivery_Location_Msgs { get; set; }



        public DeliveryMan()
        {
            ReciveProducts = new List<ReciveProduct>();
            orderinformations = new List<orderinformation>();
            DeliveryManReviews = new List<DeliveryManReview>();
            AssignProducts = new List<AssignProduct>();
            Delivery_Location_Msgs = new List<Delivery_Location_Msg>();



        }



    }
}
