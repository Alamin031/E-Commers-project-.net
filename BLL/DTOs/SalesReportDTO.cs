using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SalesReportDTO
    {
        public int Id { get; set; }
        public string MonthName { get; set; }
        public int TotalSales { get; set; }
        [ForeignKey("Moderator")]

        public int ReportedBy { get; set; }
    }
}
