using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DeliveryManReviewDTO
    {
        public int Id { get; set; }
        [Required]
        public string review { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]

        public int u_id { get; set; }
        [Required]

        public int o_id { get; set; }


    }
}
