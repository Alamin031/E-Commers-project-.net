using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ReciveProduct
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("AssignProduct")]
        public int ap_id { get; set; }
        public virtual AssignProduct AssignProduct { get; set; }
        [ForeignKey("DeliveryMan")]
        public string dliverym_name { get; set; }
        public virtual DeliveryMan DeliveryMan { get; set; }
        public string status { get; set; }


    }
}
