using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{

    public class AssignProductDTO
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string ProductType { get; set; }
        [Required]
        public string DeliveryDate { get; set; }
        public string Delivery_name { get; set; }
        public int m_Id { get; set; }

    }
}
