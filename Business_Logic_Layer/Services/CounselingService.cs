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
    public class CounselingService
    {
        public static List<CounselingModel> Get()
        {
            var data = DataAccess.SGetCounselingDataAccess().Get();
            var rdata = new List<CounselingModel>();
            foreach (var item in data)
            {
                rdata.Add(new CounselingModel()
                {
                    Id = item.Id,
                    CourseId = item.CourseId,
                    MentorId = item.MentorId,
                    MeetLink = item.MeetLink,
                    Details = item.Details,
                    Date = item.Date

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
        public static bool Create(CounselingModel item)
        {
            var student = new Counseling()
            {
                Id = item.Id,
                MentorId = item.MentorId,
                CourseId = item.CourseId,
                MeetLink = item.MeetLink,
                Details = item.Details,
                Date = item.Date

            };
            return DataAccess.SGetCounselingDataAccess().Create(student);
        }
        public static bool Update(Counseling student)
        {
            return DataAccess.SGetCounselingDataAccess().Update(student);
        }
        public static bool Delete(int id)
        {
            return DataAccess.SGetCourseDataAccess().Delete(id);
        }
    }
}