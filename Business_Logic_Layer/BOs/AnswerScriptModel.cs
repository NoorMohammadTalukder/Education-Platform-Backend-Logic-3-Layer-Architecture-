using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class AnswerScriptModel
    {
        public int Id { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> AssignmentId { get; set; }
        public string Answer { get; set; }
        public string Date { get; set; }
    }
}