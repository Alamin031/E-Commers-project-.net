using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ShowAssignProductDTO
    {
        public List<UserDTO> DeliveryManReviews { get; set; }
        public DUserDTO User { get; set; }
        public OrderDTO Orders { get; set; }


        public ShowAssignProductDTO()
        {
            DeliveryManReviews = new List<UserDTO>();
        }
    }
}
