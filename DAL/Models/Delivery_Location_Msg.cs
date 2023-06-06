using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Delivery_Location_Msg
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Location { get; set; }
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        [ForeignKey("DeliveryMan")]
        public string Delivery_Boy_name { get; set; }
        public virtual DeliveryMan DeliveryMan { get; set; }
    }
}
