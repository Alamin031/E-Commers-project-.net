using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDetailsDTO
    {
        public int Id { get; set; }
        [Required]

        public int OrderId { get; set; }
        [Required]

        public int ProductId { get; set; }
        [Required]

        public string SelleBy { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string price { get; set; }

        [Required]
        public string Status { set; get; }
    }
}
