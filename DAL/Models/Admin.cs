using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Admin
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

        public virtual ICollection<Moderator> Moderators { get; set; }
        //public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<SalesReport> SalesReports { get; set; }



        public Admin()
        {
            Moderators = new List<Moderator>();
            //Products = new List<Product>();
            SalesReports = new List<SalesReport>();

        }




    }
}
