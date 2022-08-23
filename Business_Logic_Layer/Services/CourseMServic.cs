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
    public class CourseMServic
    {
        public static List<CourseMModel> Get()
        {
            var data = DataAccess.SGetCourseModuleDataAccess().Get();
            var rdata = new List<CourseMModel>();
            foreach (var item in data)
            {
                rdata.Add(new CourseMModel()
                {
                    Id = item.Id,
                    CourseId = item.CourseId,
                    MentorId = item.MentorId,
                    Material = item.Material,
                    Description = item.Description,
                    Module = item.Module,
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
        public static bool Create(CourseMModel item)
        {
            var student = new CourseModule()
            {
                Id = item.Id,
                CourseId = item.CourseId,
                MentorId = item.MentorId,
                Material = item.Material,
                Description = item.Description,
                Module = item.Module,
                Date = item.Date

            };
            return DataAccess.SGetCourseModuleDataAccess().Create(student);
        }
        public static bool Update(CourseModule student)
        {
            return DataAccess.SGetCourseModuleDataAccess().Update(student);
        }
        public static bool Delete(int id)
        {
            return DataAccess.SGetCourseDataAccess().Delete(id);
        }
    }
}