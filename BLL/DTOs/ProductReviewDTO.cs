using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductReviewDTO : ProductDTO
    {
        public List<ReviewDTO> Reviews { get; set; }
        public UserDTO Users { get; set; } 
        public ProductReviewDTO()
        {
            Reviews = new List<ReviewDTO>();
        }
    }
}
