using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class PasswordChangeRequestModel
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Status { get; set; }
        public string Requester { get; set; }
    }
}
