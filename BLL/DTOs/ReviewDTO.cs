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
    public class ReviewDTO
    {
        public int Id { get; set; }
        [Required]
        public string review { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public int uid { get; set; }
        public int pid { get; set; }
    }
}
