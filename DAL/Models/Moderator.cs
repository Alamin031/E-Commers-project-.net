using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Moderator
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Uname { get; set; }
        [Required]
        [StringLength(15)]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }

        [ForeignKey("Admin")]

        public int AddedBy { get; set; }

        public Admin Admin { get; set; }

        public virtual ICollection<SalesReport> SalesReports { get; set; }
        public virtual ICollection<AssignProduct> AssignProducts { get; set; }




        public Moderator()
        {
            SalesReports = new List<SalesReport>();
            AssignProducts = new List<AssignProduct>();


        }



    }
}
