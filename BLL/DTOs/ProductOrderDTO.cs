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
    public class ProductOrderDTO
    {
        public int Id { get; set; }
        [Required]
        public int Oid { get; set; }
        [Required]
        public int pid { get; set; }
    }
}
