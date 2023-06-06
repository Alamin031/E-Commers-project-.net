using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User_Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Oid { get; set; }
        [ForeignKey("Oid")]
        public Order Order { get; set; }
        [Required]
        public int Uid { get; set; }
        [ForeignKey("Uid")]
        public User User { get; set; }

        [Required]
        public string PaymentBy { get; set; }
        public virtual ICollection<orderinformation> orderinformations { get; set; }
        public User_Order()
        {
            orderinformations = new List<orderinformation>();

        }

    }
}
