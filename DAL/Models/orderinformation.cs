using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class orderinformation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Orders")]
        public int or_id { get; set; }
        public virtual Order Orders { get; set; }
        [ForeignKey("User_Order")]
        public int user_or_id { get; set; }
        public virtual User_Order User_Order { get; set; }

        [ForeignKey("DeliveryMan")]
        public string dliverym_name { get; set; }
        public virtual DeliveryMan DeliveryMan { get; set; }



    }
}
