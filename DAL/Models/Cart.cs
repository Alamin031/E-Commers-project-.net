using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int uid { get; set; }
        [ForeignKey("uid")]
        public User User { get; set; }
        [Required]
        public int pid { get; set; }
        [ForeignKey("pid")]
        public Product product { get; set; }
        [Required]
        public int Quantity { get; set; }

    }
}
