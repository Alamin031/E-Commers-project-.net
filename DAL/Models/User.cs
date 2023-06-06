using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string uname { get; set; }
        [Required]
        [StringLength(15)]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }

        public virtual ICollection<User_Order> UserOrders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<DeliveryManReview> DeliveryManReviews { get; set; }


        public User()
        {
            UserOrders = new List<User_Order>();
            Reviews = new List<Review>();
            Carts = new List<Cart>();
            DeliveryManReviews = new List<DeliveryManReview>();


        }

    }
}
