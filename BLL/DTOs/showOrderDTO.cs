using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class showOrderDTO : orderinformationDTO
    {
        public List<OrderDTO> orderinformationsS { get; set; }
        public User_OrderDTO User_Order { get; set; }
        public OrderDTO Orders { get; set; }

        public showOrderDTO()
        {
            orderinformationsS = new List<OrderDTO>();
        }
    }
}
