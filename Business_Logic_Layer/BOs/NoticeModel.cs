using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class NoticeModel
    {
        public int Id { get; set; }
        public Nullable<int> CourseId { get; set; }
        public string AnnouncedBy { get; set; }
        public Nullable<int> InstitutionId { get; set; }
        public string Details { get; set; }
        public string Date { get; set; }
        public Nullable<int> MentorId { get; set; }


    }
}