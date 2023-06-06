using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ShowReviewDTO : DeliveryManReviewDTO
    {
        public List<UserDTO> DeliveryManReviews { get; set; }
        public DUserDTO User { get; set; }
        public OrderDTO Orders { get; set; }



        public ShowReviewDTO()
        {
            DeliveryManReviews = new List<UserDTO>();
        }
    }
}
