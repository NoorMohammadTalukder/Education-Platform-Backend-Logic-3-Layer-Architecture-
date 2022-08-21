using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class TransactionModel
    {
        public int Id { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> InstitutionId { get; set; }
        public string BkashTransactionNumber { get; set; }
        public string Date { get; set; }
        public Nullable<double> CreditedAmount { get; set; }
    }
}
