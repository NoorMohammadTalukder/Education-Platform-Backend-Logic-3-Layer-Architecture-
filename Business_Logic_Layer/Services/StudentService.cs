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
    public class studentService
    {
        public static List<StudentModel> Get()
        {
            var data = DataAccess.GetStudentDataAccess().Get();
            var rdata = new List<StudentModel>();
            foreach (var item in data)
            {
                rdata.Add(new StudentModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Address = item.Address,
                    Email = item.Email,
                    Phone = item.Phone,
                    Education = item.Education,
                    Password = item.Password,
                    Institution = item.Institution,
                    IsValid = item.IsValid,
                    Gender = item.Gender
                });
            }
            return rdata;
        }
        public static List<Student> GetVarStudentCount(int count)
        {
            return DataAccess.GetStudentDataAccess().Get().Take(count).ToList();
        }
        //public static studentModel GetUser(int id)
        //{
        //    var item = DataAccess.GetStudentDataAccess().Get(id);

        //    var d = new studentModel() { id = item.id, name = item.name, email = item.email, user_id = item.user_id, password = item.password, rules = item.rules, status = item.status, img = item.img };
        //    return d;
        //}
        public static bool Create(StudentModel item)
        {
            var student = new Student()
            {
                Id = item.Id,
                Name = item.Name,
                Address = item.Address,
                Email = item.Email,
                Phone = item.Phone,
                Education = item.Education,
                Password = item.Password,
                Institution = item.Institution,
                IsValid = item.IsValid,
                Gender = item.Gender

            };
            return DataAccess.GetStudentDataAccess().Create(student);
        }
        public static bool Update(Student student)
        {
            return DataAccess.GetStudentDataAccess().Update(student);
        }
        public static bool Delete(int id)
        {
            return DataAccess.GetStudentDataAccess().Delete(id);
        }
    }
}