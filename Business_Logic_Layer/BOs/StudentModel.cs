using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class StudentModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] Photo { get; set; }
        public string Education { get; set; }
        public string Institution { get; set; }
        public string Password { get; set; }
        public string IsValid { get; set; }
        public string Gender { get; set; }
    }
}