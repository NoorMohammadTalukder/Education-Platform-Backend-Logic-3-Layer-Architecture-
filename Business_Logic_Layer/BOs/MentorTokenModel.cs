using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class MentorTokenModel
    {
        public int Id { get; set; }
        public Nullable<int> MentorId { get; set; }
        public string Createdat { get; set; }
        public string Expiredat { get; set; }
        public string Token { get; set; }
    }
}