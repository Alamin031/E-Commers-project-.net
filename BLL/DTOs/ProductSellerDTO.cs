using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public  class ProductSellerDTO : ProductDTO
    {
        public SellerDTO Seller { get; set; }
    }
}
