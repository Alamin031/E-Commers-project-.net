using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ModeratorSalesReportDTO : ModeratorDTO
    {
        public List<SalesReportDTO> SalesReports { get; set; }

        public ModeratorSalesReportDTO()
        {
            SalesReports = new List<SalesReportDTO>();
        }
    }
}