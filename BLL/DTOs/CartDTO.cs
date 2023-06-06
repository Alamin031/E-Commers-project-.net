using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CartDTO
    {
        public int Id { get; set; }
        [Required]
        public int uid { get; set; }
        [Required]
        public int pid { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
