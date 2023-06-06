using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DeliveryManReview
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string review { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        [ForeignKey("User")]
        public int u_id { get; set; }

        public virtual User User { get; set; }

        [Required]
        [ForeignKey("Orders")]
        public int o_id { get; set; }

        public virtual Order Orders { get; set; }



        [ForeignKey("DeliveryMan")]
        public string Delivery_name { get; set; }
        public virtual DeliveryMan DeliveryMan { get; set; }

        public virtual ICollection<DFeedBack> DFeedBacks { get; set; }

        public DeliveryManReview()
        {
            DFeedBacks = new List<DFeedBack>();
        }


    }
}
