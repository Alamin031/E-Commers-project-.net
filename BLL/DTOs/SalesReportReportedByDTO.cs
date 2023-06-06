using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SalesReportReportedBy : SalesReportDTO
    {
        public ModeratorDTO Moderator { get; set; }

        public SalesReportReportedBy()
        {
            Moderator= new ModeratorDTO();
        }
    }
}