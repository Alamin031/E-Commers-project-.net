using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public  class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductCategory { get; set; }
        [Required]
        public string ProductPrice { get; set; }
        [Required]
        public string ProdcutQuantity { get; set; }
        [Required]
        public string SelleingBy { get; set; }

    }
}
