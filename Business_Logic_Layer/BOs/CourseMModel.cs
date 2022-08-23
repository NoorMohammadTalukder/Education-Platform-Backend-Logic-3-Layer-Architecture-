using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class CourseMModel
    {
        public int Id { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> MentorId { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string Module { get; set; }
        public string Date { get; set; }
    }
}