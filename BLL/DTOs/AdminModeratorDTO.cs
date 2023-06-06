using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminModeratorDTO :AdminDTO
    {
        public List<ModeratorDTO> Moderators { get; set; }

        public AdminModeratorDTO()
        {
            Moderators = new List<ModeratorDTO>();
        }
    }
}
