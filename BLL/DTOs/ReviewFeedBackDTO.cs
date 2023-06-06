using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReviewFeedBackDTO : ReviewDTO
    {
        public List<FeedBackDTO> FeedBacks { get; set; }
        public UserDTO User { get; set; }
        public ReviewFeedBackDTO()
        {
            FeedBacks = new List<FeedBackDTO>();
        }
    }
}
