using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public Nullable<double> Price { get; set; }
        public string Duration { get; set; }
        public string Date { get; set; }
        public string Photo { get; set; }
        public Nullable<int> InstitutionId { get; set; }
        public Nullable<int> MentorId { get; set; }
    }
}
