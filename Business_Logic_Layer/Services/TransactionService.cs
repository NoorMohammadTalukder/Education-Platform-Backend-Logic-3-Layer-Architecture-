using Business_Logic_Layer.BOs;
using Data_Access_Layer;
using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services
{
    public class TransactionService
    {
        public static List<TransactionModel> Get()
        {
            var data = DataAccess.GetTransactionDataAccess().Get();
            var rdata = new List<TransactionModel>();
            foreach (var item in data)
            {
                rdata.Add(new TransactionModel()
                {
                    Id = item.Id,
                    CourseId = item.CourseId,
                    StudentId = item.StudentId,
                    InstitutionId = item.InstitutionId,
                    BkashTransactionNumber = item.BkashTransactionNumber,
                    Date = item.Date,
                    CreditedAmount = item.CreditedAmount



                });
            }
            return rdata;
        }
        //public static List<CourseModel> GetVarStudentCount(int count)
        //{
        //    return DataAccess.GetCourseDataAccess().Get().Take(count).ToList();
        //}
        ////public static CourseModel GetUser(int id)
        //{
        //    var item = DataAccess.GetCourseDataAccess().Get(id);

        //    var d = new CourseModel() { id = item.id, name = item.name, email = item.email, user_id = item.user_id, password = item.password, rules = item.rules, status = item.status, img = item.img };
        //    return d;
        //}
        public static bool Create(TransactionModel item)
        {
            var student = new Transaction()
            {
                Id = item.Id,
                CourseId = item.CourseId,
                StudentId = item.StudentId,
                InstitutionId = item.InstitutionId,
                BkashTransactionNumber = item.BkashTransactionNumber,
                Date = item.Date,
                CreditedAmount = item.CreditedAmount,


            };
            return DataAccess.GetTransactionDataAccess().Create(student);
        }
        public static bool Update(Transaction student)
        {
            return DataAccess.GetTransactionDataAccess().Update(student);
        }
        public static bool Delete(int id)
        {
            return DataAccess.GetCourseDataAccess().Delete(id);
        }
    }
}