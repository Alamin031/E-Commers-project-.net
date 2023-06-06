using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductOrderDetailsDTO : ProductDTO
    {
        public List<OrderDTO> Orders { get; set; }
        public ProductOrderDetailsDTO()
        {
            Orders = new List<OrderDTO>();
        }
    }
}
