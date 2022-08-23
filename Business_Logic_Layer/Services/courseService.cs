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
    public class courseService
    {
        public static List<CourseModel> Get()
        {
            var data = DataAccess.SGetCourseDataAccess().Get();
            var rdata = new List<CourseModel>();
            foreach (var item in data)
            {
                rdata.Add(new CourseModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Details = item.Details,
                    Price = item.Price,
                    Duration = item.Duration,
                    Date = item.Date,
                    Photo = item.Photo,
                    InstitutionId = item.InstitutionId,
                    MentorId = item.MentorId,
                });
            }
            return rdata;
        }
        public static List<Cours> GetVarStudentCount(int count)
        {
            return DataAccess.SGetCourseDataAccess().Get().Take(count).ToList();
        }
        //public static CourseModel GetUser(int id)
        //{
        //    var item = DataAccess.GetCourseDataAccess().Get(id);

        //    var d = new CourseModel() { id = item.id, name = item.name, email = item.email, user_id = item.user_id, password = item.password, rules = item.rules, status = item.status, img = item.img };
        //    return d;
        //}
        public static bool Create(CourseModel item)
        {
            var student = new Cours()
            {
                Id = item.Id,
                Name = item.Name,
                Details = item.Details,
                Price = item.Price,
                Duration = item.Duration,
                Date = item.Date,
                Photo = item.Photo,
                InstitutionId = item.InstitutionId,
                MentorId = item.MentorId,

            };
            return DataAccess.SGetCourseDataAccess().Create(student);
        }
        public static bool Update(Cours student)
        {
            return DataAccess.SGetCourseDataAccess().Update(student);
        }
        public static bool Delete(int id)
        {
            return DataAccess.SGetCourseDataAccess().Delete(id);
        }
    }
}