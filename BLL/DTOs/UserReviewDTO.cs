using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserReviewDTO : UserDTO
    {
        public List<ReviewDTO> Reviews { get; set; }
        public UserReviewDTO()
        {
            Reviews = new List<ReviewDTO>();
        }
    }
}