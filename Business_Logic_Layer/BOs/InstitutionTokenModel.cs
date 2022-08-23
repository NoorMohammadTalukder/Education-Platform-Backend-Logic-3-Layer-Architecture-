using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class InstitutionTokenModel
    {
        public int Id { get; set; }
        public Nullable<int> InstitutionId { get; set; }
        public string CreatedAt { get; set; }
        public string ExpiredAt { get; set; }
        public string Token { get; set; }
    }
}