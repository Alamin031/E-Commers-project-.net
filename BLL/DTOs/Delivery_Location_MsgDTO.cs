using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class Delivery_Location_MsgDTO
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Delivery_Boy_name { get; set; }
    }
}
