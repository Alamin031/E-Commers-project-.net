using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DUserDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string uname { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
