using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class CertificateModel
    {
        public int Id { get; set; }
        public string RecomendBy { get; set; }
        public Nullable<int> InstitutionId { get; set; }
        public Nullable<int> CourseId { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string Date { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> MentorId { get; set; }
    }
}